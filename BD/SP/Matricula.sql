use SGA
go

--MATRICULA
create proc IngresarMatricula
(
@AlumnoId int, 
@GradoId INT ,
@Seccion nvarchar(10),
@Repitente CHAR(2),
@TurnoId INT,
@ColegioId INT
)
as
begin
declare @MatriculaId int
declare @CicloEscolarId INT
declare @FechaMatricula DATE
set @FechaMatricula = GETDATE()
set @CicloEscolarId = (select Ciclo from dba.Parametros where Descripcion = 'CicloAcademico')
select @MatriculaId = isnull(Max(MatriculaId),0) + 1 from Matricula
	insert into Matricula values
	(
	@MatriculaId,
	@CicloEscolarId,
	@AlumnoId, 
	@GradoId, 
	@Seccion,
	@FechaMatricula,
	@Repitente,
	@TurnoId,
	@ColegioId
	)
end
go

--TRiggers
--Desconctar vacantes de Grados
create trigger DescontarVacantesAulas
on  Matricula after insert
as
begin
		declare  @Grado int = (select GradoId from inserted)
		declare @TurnoId int = (select TurnoId  from inserted)
		declare @seccion nvarchar(10) = (select Seccion from inserted)
		update dba.Aulas set 
		Vacantes = Vacantes - 1
		where GradoId = @Grado and TurnoId = @TurnoId and @seccion = Aula
end
go

--Mostar Vacantes or aula
create proc mostrarVacantesAula
(
@Turno int,
@Gradoid int
)
as
begin
select Aula,Vacantes from dba.Aulas
where GradoId = @Gradoid and TurnoId = @Turno
end
go



--ReporteMatricula
alter proc BoletaMatricula
(
@Matriculaid int
)
as
begin
select MatriculaId,FechaMatricula,CicloEscolar, M.AlumnoId, A.Nombres + ' ' + A.Apellidos [Estudiante],
M.GradoId, G.Grado, Seccion, M.TurnoId, T.Turno
from Matricula M
inner join Alumnos A ON M.AlumnoId = A.AlumnoId
INNER JOIN dba.Grados G ON M.GradoId = G.GradoId
INNER JOIN dba.Turnos T ON M.TurnoId = T.TurnoId
where MatriculaId = @Matriculaid
end
go

create proc ListaMatricula
as
begin
select 
MatriculaId,
FechaMatricula,
CicloEscolar,
M.AlumnoId,
A.Nombres + ' ' + A.Apellidos [Estudiante],
M.GradoId,
G.Grado, 
Seccion, 
M.TurnoId, 
T.Turno, 
'Colegio' = 
CASE
WHEN M.CicloEscolar = 0 THEN ''
ELSE
(SELECT Colegio FROM dba.Colegio where ColegioId = m.ColegioId)
END,
m.Repitente
from Matricula M
inner join Alumnos A ON M.AlumnoId = A.AlumnoId
INNER JOIN dba.Grados G ON M.GradoId = G.GradoId
INNER JOIN dba.Turnos T ON M.TurnoId = T.TurnoId
end
go

create proc ListaAlumnoMatricula
as
begin
select a.AlumnoId,Nombres,Apellidos,Sexo,FechaNacimiento,Direccion,CodigoMined,Activo
 from Alumnos a
inner join DocumentosAlumnos d on a.AlumnoId=d.AlumnoId
inner join PadresTutorAlumno p on a.AlumnoId=p.AlumnoId
inner join AlumnosTutor ATU on a.AlumnoId = ATU.AlumnoId
where a.AlumnoId not in (select AlumnoId from Matricula)
end
go


