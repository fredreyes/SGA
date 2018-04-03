--departamentos
create proc IngresarDepartamento
(
@Departamento nvarchar(150)
)
as
begin
		insert into Departamentos
		values
		(
			@Departamento
		)
end
go
create proc ModificarDepartamento
(
@DepartamentoId int,
@Departamento nvarchar(150)
)
as
begin
	begin try
		update Departamentos
		set
			Departamento = @Departamento
			where DepartamentoId = @DepartamentoId
	end try
	begin catch
		if @@TRANCOUNT > 0
			rollback
	end catch
end
go

create proc EliminarDepartamento
(
@DepartamentoID int
)
as
begin
delete Departamentos where DepartamentoID = @DepartamentoID
end
go

--COLEGIO
create proc IngresarColegio
(
@Colegio nvarchar(100),
@Telefono nvarchar(20),
@DepartamentoId int
)
as
begin
		insert into Colegio values
		(
			@Colegio,
			@Telefono,
			@DepartamentoId
		)
end
go
create proc ModificarColegio
(
@ColegioId int,
@Colegio nvarchar(100),
@Telefono nvarchar(20),
@DepartamentoId int
)
as
begin
		begin try
		update Colegio set
			Colegio =	@Colegio,
			Telefono = @Telefono,
			DepartamentoId = @DepartamentoId
			where ColegioId = @ColegioId
		end try
		begin catch
			if @@TRANCOUNT > 0
				rollback
		end catch
end
go
create proc EliminarColegio
(
@ColegioId int
)
as
begin
delete Colegio where ColegioId = @ColegioId
end
go


--PROFESION OCUPACION
create proc InsertarOcupacion
(
@Ocupacion nvarchar (150)
)
as
begin
	begin try
					insert into ProfesionOcupacion
					values
					(
					@Ocupacion
					)
		end try
		begin catch
			if @@TRANCOUNT > 0
		rollback
		end catch
end
go
CREATE PROC EditarOcupacion
(
@OcupacionId int,
@Ocupacion nvarchar (150)
)
as
begin
		begin try
					update ProfesionOcupacion set
					Ocupacion = @Ocupacion
					where  @OcupacionId = OcupacionId
		end try
		begin catch
			if @@TRANCOUNT > 0
		rollback
		end catch
end
go
create proc eliminarOcupacion
(
@ocupacionId int
)
as
begin
	delete ProfesionOcupacion where OcupacionId = @ocupacionId
end
go

--TURNOS
create proc InsertarTurnos
(
@Turno nvarchar(200),
@Descripcion nvarchar(200)
)
as
begin
		declare @activo bit
		set @activo = 1		
		insert into Turnos
		values
		(
		@Turno,
		@Descripcion,
		@activo
		)
end
go

create proc ModificarTurnos
(
@TurnoId int,
@Turno nvarchar(200),
@Descripcion nvarchar(200),
@Activo bit
)
as
begin
		update Turnos set
		Turno = @Turno,
		Descripcion = @Descripcion,
		Activo = @activo
		where TurnoId = @TurnoId
end
GO
create proc eliminarTurno
(
@TurnoId int
)
as
begin
	delete Turnos where TurnoId = @TurnoId
end
GO

-- GRADOS
create proc InsertarGrados
(
@Grado nvarchar(20),
@Tipo char(1)
)
as
begin
	begin try
	declare @activo bit
	set @activo = 1
		insert into Grados 
		values
		(
		@Grado,
		@Tipo,
		@activo
		)
	end try
	begin catch
	if @@TRANCOUNT > 0
		rollback
	end catch
end
go

create proc ModificarGrados
(
@GradoId int,
@Grado nvarchar(20),
@Tipo char(1),
@Activo bit
)
as
begin
	begin try
	update Grados 
		set		
		Grado = @Grado,
		Tipo = @Tipo,
		Activo = @activo
		where GradoId = @GradoId
	end try
	begin catch
	if @@TRANCOUNT > 0
		rollback
	end catch
end
go
create proc eliminarGrado
(
@GradoId int
)
as
begin
	delete Grados where GradoId  = @GradoId
end
go

--Asignatura
create proc IngresarAsignatura
(
@Asignatura nvarchar(100)
)
as
begin
		declare @activo bit
		set @activo = 1
		insert into Asignaturas values
		(
		@Asignatura,
		@activo
		)
end
go

create proc ModificarAsignatura
(
@AsignaturaId int,
@Asignatura nvarchar(100),
@activo bit
)
as
begin
		update Asignaturas set
		Asignatura = @Asignatura,
		Activo = @activo
		where AsignaturaId = @AsignaturaId
end
go

create proc EliminarAsignatura
(
@AsignaturaId int
)
as
begin
		delete Asignaturas
		where AsignaturaId = @AsignaturaId
end
go

--CICLO  ESCOLAR
create proc IngresarCicloEscolar
(
@Ciclo int,
@FechaInicio date,
@FechaFin date
)
as
begin
		declare @activo bit
		set @activo = 1
		insert into CicloEscolar values
		(
		@Ciclo,
		@FechaInicio,
		@FechaFin,
		@activo
		)
end
go

create proc ModificarCicloEscolar
(
@CicloEscolarId int,
@Ciclo int,
@FechaInicio date,
@FechaFin date,
@Activo bit
)
as
begin
		update CicloEscolar set
		Ciclo = @Ciclo,
		FechaInicio =@FechaInicio,
		FechaFin = @FechaFin,
		Activo = @activo
		where CicloEscolarId = @CicloEscolarId
end
go


create proc EliminarCicloEscolar
(
@CicloEscolarId int
)
as
begin
		delete CicloEscolar 
		where CicloEscolarId = @CicloEscolarId
end
go

--AULAS
create proc IngresarAula
(
@Aula nvarchar(30),
@capacidad int,
@Vacantes int,
@GradoId int,
@Turno nvarchar(50)
)
as
begin
		declare @activo bit
		set @activo = 1
		insert into Aulas values
		(
		@Aula,
		@capacidad,
		@Vacantes,
		@GradoId,
		@Turno,
		@activo
		)
end
go


create proc ModificarAula
(
@AulaId int,
@Aula nvarchar(30),
@capacidad int,
@Vacantes int,
@GradoId int,
@Turno nvarchar(50),
@activo bit
)
as
begin
		update Aulas set
		Aula = @Aula,
		Capacidad = @capacidad,
		Vacantes = @Vacantes,
		GradoId = @GradoId,
		Turno = @Turno,
		Activo = @activo
		where AulaId = @AulaId
end
go

create proc EliminarAulas
(
@AulaId int
)
as
begin
delete Aulas where AulaId = @AulaId
end
go

--Evaluaciones

create proc InsertarEvaluaciones
(
@Mes NVARCHAR(20),
@Pacial NVARCHAR(30),
@Observaciones NVARCHAR(300),
@CicloEscolarId INT
)
as
begin
		declare @activo bit
		set @activo = 1
		insert into Evaluaciones
		values
		(
		@Mes,
		@Pacial,
		@Observaciones,
		@CicloEscolarId,
		@activo
		)
end
go

create proc EliminarEvaluaciones
(
@EvaluacionId INT
)
as
begin
		delete Evaluaciones
		where EvaluacionId = @EvaluacionId
end
go

--FUNCIONARIOS
create PROC IngresarFuncioarios
(
@Nombres nvarchar(100),
@Apellidos nvarchar(100),
@Cedula nvarchar(18) ,
@Sexo char (1),--F,M
@FechaNacimiento DATE,
@Telefono nvarchar(15),
@Cargo nvarchar(40) ,
@OcupacionId INT,
@Email nvarchar(100),
@Foto Image,
@IsDocente bit 
)
AS
BEGIN
		declare @activo bit
		set  @activo = 1
		insert into Funcionarios values
		(
		@Nombres,
		@Apellidos,
		@Cedula,
		@Sexo,--F,M
		@FechaNacimiento,
		@Telefono,
		@Cargo,
		@OcupacionId,
		@Email,
		@Foto,
		@activo,
		@IsDocente
		)
END
GO


create PROC ModificarFuncioarios
(
@FuncionarioId int,
@Nombres nvarchar(100),
@Apellidos nvarchar(100),
@Cedula nvarchar(18) ,
@Sexo char (1),--F,M
@FechaNacimiento DATE,
@Telefono nvarchar(15),
@Cargo nvarchar(40) ,
@OcupacionId INT,
@Email nvarchar(100),
@Foto Image,
@activo bit,
@IsDocente bit 
)
AS
BEGIN
		update Funcionarios set
		Nombres = @Nombres,
		Apellidos = @Apellidos,
		Cedula = @Cedula,
		Sexo = @Sexo,--F,M
		FechaNacimiento = @FechaNacimiento,
		Telefono = @Telefono,
		Cargo = @Cargo,
		OcupacionId = @OcupacionId,
		 Email =@Email,
		Foto = @Foto,
		Activo = @activo,
		isDocente = @IsDocente 
		where FuncionarioId = @FuncionarioId
END
GO
--Crear Historial de cargo de Docente
create trigger InsertarHistorialCargoDocente
on Funcionarios after update,insert
as
begin
declare @FuncionarioId int = (select FuncionarioId from inserted)
declare @Cargo nvarchar(100) = (select Cargo from Funcionarios where FuncionarioId = @FuncionarioId)
declare  @Fecha date = getdate()
		if @FuncionarioId is null
		begin
				insert into HistorialCargoFuncionaario values
				(
				@FuncionarioId,
				@Cargo,
				@Fecha
				)
		end
		else
		begin
		insert into HistorialCargoFuncionaario values
				(
				@FuncionarioId,
				@Cargo,
				@Fecha
				)
		end
end
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
@CicloEscolarId INT,
@AlumnoId int, 
@GradoId INT , 
@FechaMatricula DATE,
@Repitente CHAR(2),
@TurnoId INT,
@ColegioId INT
)
as
begin
declare @MatriculaId int
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
create trigger DescontarVacantesAulas
on  Matricula after insert
as
begin
		 
		declare  @Grado int = (select GradoId from inserted)
		declare @Turno nvarchar = (select IIF(TurnoId = 1,'Matutino','Vespertino') from inserted) 
		update Aulas set 
		Vacantes = Vacantes - 1
		where GradoId = @Grado  and Turno = @Turno
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

