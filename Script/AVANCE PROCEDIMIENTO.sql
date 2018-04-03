use SGA
go
--Estudiantes
create proc IngresarEstudiante
(
--Alumnos
@Nombres nvarchar(30),
@Apellidos nvarchar(30),
@Sexo CHAR(1),
@FechaNacimiento DATE,
@Direccion nvarchar(200),
@CodigoMined int,
--Padres
@NombresPadres nvarchar(200),
@CedulaPadre NVARCHAR(18),
@TelefonoPadre nvarchar(15),
@EmailPadre NVARCHAR(100),
@OcupacionPadre NVARCHAR(150),
@NombresMadres nvarchar(200),
@CedulaMadre NVARCHAR(18),
@TelefonoMadre nvarchar(15),
@EmailMadre NVARCHAR(100),
@OcupacionMadre NVARCHAR(150),
--AlumnosTutor
@NombreTutor NVARCHAR(150),
@CedulaTutor NVARCHAR(16),
@TelefonoTutor NVARCHAR(15),
@ParentezcoAlumno NVARCHAR(50),
--Documentos Alumnos
@PartidaNaciminto CHAR(2),
@CertificadoNotas CHAR(2),
@TarjetaVacuna CHAR(2),
@CartaTraslado CHAR(2),
@CertificadoSalud CHAR(2),
@Foto IMAGE
)
as
begin 
declare @Activo bit
set @Activo = 1
DECLARE @ID int
declare @Año int = (select RIGHT(Ciclo,2) from CicloEscolar where Activo = 1)
declare @Sumar int  = (select top 1 COUNT(AlumnoId) from Alumnos where LEFT(AlumnoId,2) = @Año group by left(AlumnoId,2)) + 2
select @ID = CONCAT(@Año,'0000')+ @Sumar
select @ID
		Begin Tran 
					insert into Alumnos values
			(
			@ID,
			@Nombres,
			@Apellidos,
			@Sexo,
			@FechaNacimiento,
			@Direccion,
			@CodigoMined,
			@Activo
			)
				if @ID is not null
				begin
				declare @PadresTutorId INT
				select @PadresTutorId = ISNULL(max(PadresTutorId),0) +1 from PadresTutorAlumno
					insert into PadresTutorAlumno 
					values 
					(
					@PadresTutorId,
					@ID,
					@NombresPadres,
					@CedulaPadre,
					@TelefonoPadre,
					@EmailPadre,
					@OcupacionPadre,
					@NombresMadres,
					@CedulaMadre,
					@TelefonoMadre,
					@EmailMadre,
					@OcupacionMadre
					)
				--TUTOR
				declare @TutorAlumnoID INT
				select @TutorAlumnoID = ISNULL(max(TutorAlumnoID),0) +1 from AlumnosTutor
				insert into AlumnosTutor values 
				(
				@TutorAlumnoID,
				@ID,
				@NombreTutor,
				@CedulaTutor,
				@TelefonoTutor,
				@ParentezcoAlumno
				)
				--documentos
				declare @DocumentoId INT
				select @DocumentoId = ISNULL(max(DocumentoId),0) +1 from DocumentosAlumnos
				insert into DocumentosAlumnos values
				(
				@DocumentoId,
				@ID,
				@PartidaNaciminto,
				@CertificadoNotas,
				@TarjetaVacuna,
				@CartaTraslado,
				@CertificadoSalud,
				@Foto
				)
				end
		commit
		if @@TRANCOUNT> 1
		Rollback tran
end
go

create proc ModificarEstudiante
(
--Alumnos
@AlumnoID int,
@Nombres nvarchar(30),
@Apellidos nvarchar(30),
@Sexo CHAR(1),
@FechaNacimiento DATE,
@Direccion nvarchar(200),
@CodigoMined int,
@Activo bit,
--Padres
@NombresPadres nvarchar(200),
@CedulaPadre NVARCHAR(18),
@TelefonoPadre nvarchar(15),
@EmailPadre NVARCHAR(100),
@OcupacionPadre NVARCHAR(150),
@NombresMadres nvarchar(200),
@CedulaMadre NVARCHAR(18),
@TelefonoMadre nvarchar(15),
@EmailMadre NVARCHAR(100),
@OcupacionMadre NVARCHAR(150),
--AlumnosTutor
@NombreTutor NVARCHAR(150),
@CedulaTutor NVARCHAR(16),
@TelefonoTutor NVARCHAR(15),
@ParentezcoAlumno NVARCHAR(50),
--Documentos Alumnos
@PartidaNaciminto CHAR(2),
@CertificadoNotas CHAR(2),
@TarjetaVacuna CHAR(2),
@CartaTraslado CHAR(2),
@CertificadoSalud CHAR(2),
@Foto IMAGE
)
as
begin 
		Begin Tran 
			update Alumnos set
			Nombres = @Nombres,
			Apellidos = @Apellidos,
			Sexo = @Sexo,
			FechaNacimiento = @FechaNacimiento,
			Direccion = @Direccion,
			CodigoMined = @CodigoMined,
			Activo = @Activo
			where AlumnoId = @AlumnoID
				if @AlumnoID is not null
				begin
				update PadresTutorAlumno set
					NombresPadres = @NombresPadres,
					CedulaPadre = @CedulaPadre,
					TelefonoPadre = @TelefonoPadre,
					EmailPadre = @EmailPadre,
					OcupacionPadre = @OcupacionPadre,
					NombresMadres = @NombresMadres,
					CedulaMadre = @CedulaMadre,
					TelefonoMadre = @TelefonoMadre,
					EmailMadre = @EmailMadre,
					OcupacionMadre= @OcupacionMadre
					where AlumnoId = @AlumnoID

			--TUTOR
			update AlumnosTutor set
				NombreTutor = @NombreTutor,
				CedulaTutor = @CedulaTutor,
				TelefonoTutor = @TelefonoTutor,
				ParentezcoAlumno = @ParentezcoAlumno
				where AlumnoId = @AlumnoID
			--DOCUMENTOS	
				update DocumentosAlumnos set
				PartidaNaciminto = @PartidaNaciminto,
				CertificadoNotas = @CertificadoNotas,
				TarjetaVacuna = @TarjetaVacuna,
				CartaTraslado = @CartaTraslado,
				CertificadoSalud = @CertificadoSalud,
				Foto = @Foto
				where AlumnoId = @AlumnoID
				end
		commit
		if @@TRANCOUNT> 1
		Rollback tran
end
go

create proc ListarAlumno
(
@AlumnoId int
)
as
begin
select a.AlumnoId,Nombres,Apellidos,Sexo,FechaNacimiento,Direccion,CodigoMined,Activo,DocumentoId,PartidaNaciminto,CertificadoNotas,TarjetaVacuna,
CartaTraslado,CertificadoSalud,Foto,PadresTutorId,NombresPadres,CedulaPadre,TelefonoPadre,EmailPadre,OcupacionPadre,NombresMadres,CedulaMadre,
TelefonoMadre,EmailMadre,OcupacionMadre,TutorAlumnoID,NombreTutor,CedulaTutor,TelefonoTutor,ParentezcoAlumno
 from Alumnos a
inner join DocumentosAlumnos d on a.AlumnoId=d.AlumnoId
inner join PadresTutorAlumno p on a.AlumnoId=p.AlumnoId
inner join AlumnosTutor ATU on a.AlumnoId = ATU.AlumnoId
where foto is not null and a.AlumnoId = @AlumnoId  
end
go

alter proc ListaAlumnoMatricula
as
begin
select a.AlumnoId,Nombres,Apellidos,Sexo,FechaNacimiento,Direccion,CodigoMined,Activo
 from Alumnos a
inner join DocumentosAlumnos d on a.AlumnoId=d.AlumnoId
inner join PadresTutorAlumno p on a.AlumnoId=p.AlumnoId
inner join AlumnosTutor ATU on a.AlumnoId = ATU.AlumnoId
where foto is not null   
end
go

--Materia Docente 
create proc IngresarMateriaDocente
(
@FuncionarioId INT, 
@AsignaturaId INT,
@Mañana bit,
@Tarde bit,
@Primaria bit,
@secundaria bit
)
as
begin
		begin try
		declare @MateriaDocenteId INT 
		select @MateriaDocenteId = ISNULL(max(MateriaDocenteId),0)+ 1 from MateriaDocente
		insert into MateriaDocente values
		(
			@MateriaDocenteId,
			@FuncionarioId, 
			@AsignaturaId,
			@Mañana,
			@Tarde,
			@Primaria,
			@secundaria
		)
		end try
		begin catch
			if @@TRANCOUNT > 0
				rollback
		end catch
end
go
create proc ModificarMateriaDocente
(
@MateriaDocenteId INT,
@AsignaturaId INT,
@Mañana bit,
@Tarde bit,
@Primaria BIT,
@secundaria BIT
)
as
begin
		begin try
		update MateriaDocente set		
			AsignaturaId = @AsignaturaId,
			Mañana = @Mañana,
			Tarde = @Tarde,
			Primaria = @Primaria,
			Secundaria = @secundaria
		where MateriaDocenteId = @MateriaDocenteId
		end try
		begin catch
			if @@TRANCOUNT > 0
				rollback
		end catch
end
go

create proc EliminarMateriaDocente
(
@MateriaDocenteID int
)
as
begin
	delete MateriaDocente where MateriaDocenteId = @MateriaDocenteID
end
go


--Plan clase
create Proc IngresarPlanClase
(
@AsignaturaId int,
@GradoId int
)
as
begin
declare @PlanClase int
select @PlanClase = ISNULL(max(PlanClaseID),0) +1 from PlanClase 
declare @CicloEscolarID int
select @CicloEscolarID = (select CicloEscolarId from CicloEscolar where Activo = 1)

insert into PlanClase  values 
(
@PlanClase,
@AsignaturaId,
@GradoId,
@CicloEscolarID
)
end
go

create proc BuscarAsignaturaPorGrados
(
@GradoId int
)
as
begin
SELECT PlanClaseID,PC.AsignaturaId,A.Asignatura,PC.GradoId,CicloEscolarID FROM PlanClase PC
left join Grados G on PC.GradoId = G.GradoId
left join Asignaturas A on PC.AsignaturaId = A.AsignaturaId
where pc.GradoId = @GradoId
end
go


create proc BuscarDocenePorAsignatura
(
@Asignatura int
)
as
begin
select Nombres,Apellidos,Asignatura,md.FuncionarioId from MateriaDocente md
inner join Funcionarios f on md.FuncionarioId = f.FuncionarioId
left join Asignaturas a on md.AsignaturaId = a.AsignaturaId
WHERE md.AsignaturaId = @Asignatura
end
go
--CargaAcademicaDocente
create Proc InsertarCargaAcademicaDocente
(
@FuncionarioId int,
@AsingaturaId int,
@GradoId int,
@CicloEscolarID int
)
as 
begin
insert into CargaAcademicaDocente
values
(
@FuncionarioId,
@AsingaturaId,
@GradoId,
@CicloEscolarID
)
end
go

--MATRICULA
create proc IngresarMatricula
(
@AlumnoId int, 
@GradoId INT , 
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
	@FechaMatricula,
	@Repitente,
	@TurnoId,
	@ColegioId
	)
end
go

--TRiggers
--Desconctar vacantes de Grados
alter trigger DescontarVacantesAulas
on  Matricula after insert
as
begin
		declare  @Grado int = (select GradoId from inserted)
		declare @TurnoId int = (select TurnoId  from inserted) 
		declare @Turno nvarchar 
		if @TurnoId = 1
			set @Turno = 'Matutino'
		if @TurnoId = 3
			set @Turno = 'Vespertino'
		update Aulas set 
		Vacantes = Vacantes - 1
		where GradoId = @Grado 
end
go

--Mostar Vacantes or aula
create proc mostrarVacantesAula
(
@Turno nvarchar(20),
@Gradoid int
)
as
begin
select Aula,Vacantes from Aulas
where GradoId = @Gradoid and Turno = @Turno
end
go




-------------faltan--------------------------------------------Procedimientos No creados------------------------------------------------

---Calificaciones
create proc IngresarCalificaciones
(
@AlumnoId int,
@MateriaDocenteId INT,
@Acumulado INT,
@Examen INT,
@Rescate int,
@Observacion NVARCHAR(300)
)
as
begin
	begin try
	declare @CalificacionesId INT
	declare @EvaluacionId INT
	set @EvaluacionId = (select EvaluacionId from Evaluaciones where Activo = 1)
	select @CalificacionesId = ISNULL(max(CalificacionesId),0)+1 from Calificaciones 	
		insert into Calificaciones
		values
		(
		@CalificacionesId,
		@AlumnoId,
		@MateriaDocenteId,
		@Acumulado,
		@Examen,
		@Rescate,
		@EvaluacionId,
		@Observacion
		)
	end try
	begin catch
		if @@TRANCOUNT > 0
			rollback
	end catch
end
go

--USUARIOS
CREATE PROC INSERTAR_USUARIOS
(
@USUARIO_ID INT,
@USUARIO NVARCHAR(20),
@CONTRASEÑA NVARCHAR(200),
@ID_FUNCIONARIO INT
)
AS
BEGIN
		BEGIN TRY
		DECLARE @ID INT
		DECLARE @ESTADO BIT
		SELECT @ESTADO = 1
		SELECT @ID = ISNULL(MAX(USUARIO_ID),0) + 1 FROM USUARIOS
		INSERT INTO USUARIOS VALUES
		(
			@ID,
            @USUARIO, 
            HASHBYTES('SHA1',@CONTRASEÑA),
            @ESTADO,
            @ID_FUNCIONARIO
		)
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
			ROLLBACK
		END CATCH
END
GO
CREATE PROC EDITAR_CONTRASEÑA_USUARIO
(
@USUARIO_ID INT,
@CONTRASEÑA NVARCHAR(200)
)
AS
BEGIN
	BEGIN TRY 
		UPDATE USUARIOS SET
		CONTRASEÑA = @CONTRASEÑA
		WHERE USUARIO_ID = @USUARIO_ID
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK
	END CATCH
END
GO
CREATE PROC EDITAR_USUARIO
(
@USUARIO_ID INT,
@USUARIO NVARCHAR(20),
@CONTRASEÑA NVARCHAR(200),
@ESTADO BIT,
@ID_FUNCIONARIO INT
)
AS
BEGIN
	BEGIN TRY
	UPDATE USUARIOS SET
	USUARIO = @USUARIO,
	ESTADO = @ESTADO
	WHERE USUARIO_ID = @USUARIO_ID
	END TRY
	BEGIN CATCH
	END CATCH
END
GO

