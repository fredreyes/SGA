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
set @CicloEscolarId = (select CicloEscolarId from CicloEscolar where Activo = 1)
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
		update Aulas set 
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
select Aula,Vacantes from Aulas
where GradoId = @Gradoid and TurnoId = @Turno
end
go



--ReporteMatricula
create proc BoletaMatricula
(
@Matriculaid int
)
as
begin
select MatriculaId,FechaMatricula,m.CicloEscolarId, CE.Ciclo, M.AlumnoId, A.Nombres + ' ' + A.Apellidos [Estudiante],
M.GradoId, G.Grado, Seccion, M.TurnoId, T.Turno, m.ColegioId,c.Colegio
from Matricula M
inner join Alumnos A ON M.AlumnoId = A.AlumnoId
INNER JOIN Grados G ON M.GradoId = G.GradoId
INNER JOIN Turnos T ON M.TurnoId = T.TurnoId
INNER JOIN Colegio C ON M.ColegioId = C.ColegioId
INNER JOIN CicloEscolar CE ON M.CicloEscolarId = CE.CicloEscolarId
where MatriculaId = @Matriculaid
end
go

create proc ListaMatricula
as
begin
select MatriculaId,FechaMatricula,m.CicloEscolarId, CE.Ciclo, M.AlumnoId, A.Nombres + ' ' + A.Apellidos [Estudiante],
M.GradoId, G.Grado, Seccion, M.TurnoId, T.Turno, m.ColegioId,c.Colegio,Repitente
from Matricula M
inner join Alumnos A ON M.AlumnoId = A.AlumnoId
INNER JOIN Grados G ON M.GradoId = G.GradoId
INNER JOIN Turnos T ON M.TurnoId = T.TurnoId
INNER JOIN Colegio C ON M.ColegioId = C.ColegioId
INNER JOIN CicloEscolar CE ON M.CicloEscolarId = CE.CicloEscolarId
end
go