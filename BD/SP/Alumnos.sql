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

create proc ListaAlumnoMatricula
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
