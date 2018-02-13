--TURNOS
CREATE PROC INSERTAR_TURNOS
(
@TURNO VARCHAR(200),
@OBSERVACION NVARCHAR(200)
)
AS
BEGIN
		DECLARE @ID INT
		declare @activo bit
		set @activo = 1
		select @ID = ISNULL(MAX(turnoId),0)+1 FROM Turnos
		
		insert into Turnos
		values
		(
		@ID,
		@TURNO,
		@OBSERVACION,
		@activo
		)
END
go
CREATE PROC MODIFICAR_TURNOS
(
@TURNOID int,
@TURNO VARCHAR(200),
@OBSERVACION NVARCHAR(200),
@ACTIVO BIT
)
AS
BEGIN
		UPDATE  Turnos
		SET
		Turno = @TURNO,
		Descripcion = @OBSERVACION,
		Activo = @ACTIVO
		where TurnoId = @TURNOID
END
go
-- GRADOS
CREATE PROC INSERTAR_GRADOS
(
@GRADO NVARCHAR(20),
@TIPO CHAR (1)
)
AS
BEGIN
		BEGIN TRY
		DECLARE @CODIGO_GRADO INT
		SELECT @CODIGO_GRADO = ISNULL(MAX(GradoId),0) + 1 FROM GRADOS
		INSERT INTO GRADOS VALUES
		(
		@CODIGO_GRADO,
		@GRADO,
		@TIPO
		)
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
			ROLLBACK
		END CATCH
END
GO
CREATE PROC MODIFICAR_GRADOS
(
@CODIGO_GRADO INT,
@GRADO NVARCHAR(20),
@TIPO CHAR (1)
)
AS
BEGIN
		BEGIN TRY
		UPDATE GRADOS SET
		GRADO = @GRADO,
		TIPO = @TIPO
		WHERE GradoId = @CODIGO_GRADO
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
			ROLLBACK
		END CATCH
END
GO


--------------------------------------------no creados-------------------------------------------------

--COLEGIO
CREATE PROC IngresarColegio
(
@Colegio nvarchar(100)
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO Colegio VALUES
		(
			@Colegio
		)
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
				ROLLBACK
		END CATCH
END
GO

--PROFESION OCUPACION
CREATE PROC INSERTAR_OCUPACION
(
@Ocupacion NVARCHAR (70)
)
AS
BEGIN
		BEGIN TRY
			DECLARE @EXISTE NVARCHAR(70)
			DECLARE @MSG NVARCHAR(100)
					INSERT INTO PROFESION_OCUPACION
					VALUES
					(
					@Ocupacion
					)
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END
GO



--Alumno
--CREATE PROC INSERTAR_ALUMNO
--(
--@Nombre nvarchar(30),
--@Apellido nvarchar(30),
--@Sexo CHAR(1),
--@FechaNacimento DATE,
--@Direccion nvarchar(200),
--@CodigoMined int
--)
--AS
--BEGIN
--		BEGIN TRY
--			DECLARE @MINED INT
--			DECLARE @MSG NVARCHAR(100)
--			DECLARE @CODIGO NVARCHAR(10)
--			IF EXISTS (SELECT CODIGO_MINED FROM ALUMNOS WHERE CODIGO_MINED = @CODIGO_MINED)
--			BEGIN
--				SET @MSG = 'REGISTRO YA EXISTE'
--			END
--			ELSE
--				BEGIN
--				SELECT @CODIGO = ISNULL(MAX(CODIGO_ALUMNO),(SELECT RIGHT(CAST(YEAR(GETDATE())AS CHAR(4)),2) + '0000'))+ 1 FROM ALUMNOS
--				INSERT INTO ALUMNOS VALUES
--						(
--							@CODIGO,
--							@NOMBRE,
--							@APELLIDO,
--							@SEXO,
--							@FECHA_NACIMIENTO,
--							@DIRECCION,
--							@CODIGO_MINED
--						)
--				END
--		END TRY
--		BEGIN CATCH
--		IF @@TRANCOUNT > 0
--		ROLLBACK
--		END CATCH
--		SELECT @MSG AS MENSAJE
--END
--GO

--CREATE PROC EDITAR_ALUMNO
--(
--@CODIGO_ALUMNO INT,
--@NOMBRE nvarchar(30),
--@APELLIDO nvarchar(30),
--@SEXO CHAR(1),
--@FECHA_NACIMIENTO DATE,
--@DIRECCION nvarchar(200),
--@CODIGO_MINED int
--)
--AS
--BEGIN
--		BEGIN TRY
--				UPDATE  ALUMNOS SET
--				NOMBRE = @NOMBRE,
--				APELLIDO = @APELLIDO,
--				SEXO = @SEXO,
--				FECHA_NACIMIENTO = @FECHA_NACIMIENTO,
--				DIRECCION = @DIRECCION,
--				CODIGO_MINED = @CODIGO_MINED
--				WHERE CODIGO_ALUMNO = @CODIGO_ALUMNO 
--		END TRY
--		BEGIN CATCH
--		IF @@TRANCOUNT > 0
--		ROLLBACK
--		END CATCH
--END
--GO

--TUTOR

--CREATE PROC INSERTAR_PADRES_TUTOR
--(
-- @ID_PARENTEZCO INT,
-- @CODIGO_ALUMNO INT,
-- @NOMBRE_MADRE nvarchar(100),
-- @NOMBRE_PADRE nvarchar(100),
-- @OCUPACION_MADRE NVARCHAR(70),
-- @OCUPACION_PADRE NVARCHAR(70),
-- @TELEFONO_MADRE nvarchar(15),
-- @TELEFONO_PADRE nvarchar(15),
-- @NOMBRE_TUTOR NVARCHAR(100),
-- @TELEFONO_TUTOR NVARCHAR(10),
-- @CEDULA_MADRE NVARCHAR(18),
-- @CEDULA_PADRE NVARCHAR(18),
-- @EMAIL_MADRE NVARCHAR(60),
-- @EMAIL_PADRE NVARCHAR(60)
--)
--AS
--BEGIN
--		BEGIN TRY
--			DECLARE @ID INT
--			SELECT @ID = ISNULL(MAX(ID_PARENTEZCO),0) + 1 FROM PADRES_TUTOR
--						INSERT INTO PADRES_TUTOR VALUES
--						(
--							 @ID,
--							 @CODIGO_ALUMNO,
--							 @NOMBRE_MADRE,
--							 @NOMBRE_PADRE,
--							 @OCUPACION_MADRE,
--							 @OCUPACION_PADRE,
--							 @TELEFONO_MADRE,
--							 @TELEFONO_PADRE,
--							 @NOMBRE_TUTOR,
--							 @TELEFONO_TUTOR,
--							 @CEDULA_MADRE,
--							 @CEDULA_PADRE,
--							 @EMAIL_MADRE,
--							 @EMAIL_PADRE
--						)
--		END TRY
--		BEGIN CATCH
--		IF @@TRANCOUNT > 0
--		ROLLBACK
--		END CATCH
--END
--GO

--CREATE PROC EDITAR_PADRES_TUTOR
--(
-- @ID_PARENTEZCO INT,
-- @CODIGO_ALUMNO INT,
-- @NOMBRE_MADRE nvarchar(100),
-- @NOMBRE_PADRE nvarchar(100),
-- @OCUPACION_MADRE NVARCHAR(70),
-- @OCUPACION_PADRE NVARCHAR(70),
-- @TELEFONO_MADRE nvarchar(15),
-- @TELEFONO_PADRE nvarchar(15),
-- @NOMBRE_TUTOR NVARCHAR(100),
-- @TELEFONO_TUTOR NVARCHAR(10),
-- @CEDULA_MADRE NVARCHAR(18),
-- @CEDULA_PADRE NVARCHAR(18),
-- @EMAIL_MADRE NVARCHAR(60),
-- @EMAIL_PADRE NVARCHAR(60)
--)
--AS
--BEGIN
--		BEGIN TRY
--						UPDATE PADRES_TUTOR 
--						SET
--						CODIGO_ALUMNO =	 @CODIGO_ALUMNO,
--						NOMBRE_MADRE =	 @NOMBRE_MADRE,
--						NOMBRE_PADRE =	 @NOMBRE_PADRE,
--						OCUPACION_MADRE = @OCUPACION_MADRE,
--						OCUPACION_PADRE = @OCUPACION_PADRE,
--						TELEFONO_MADRE = @TELEFONO_MADRE,
--						TELEFONO_PADRE = @TELEFONO_PADRE,
--						NOMBRE_TUTOR = @NOMBRE_TUTOR,
--						TELEFENO_TUTOR = @TELEFONO_TUTOR,
--						CEDULA_MADRE = @CEDULA_MADRE,
--						CEDULA_PADRE = @CEDULA_PADRE,
--					    EMAIL_MADRE = @EMAIL_MADRE,
--						EMAIL_PADRE = @EMAIL_PADRE
--						WHERE ID_PARENTEZCO = @ID_PARENTEZCO
--		END TRY
--		BEGIN CATCH
--		IF @@TRANCOUNT > 0
--		ROLLBACK
--		END CATCH
--END
--GO

--DOCUMENTOS ALUMNOS
CREATE PROC INSERTAR_DOCUMENTO_ALUMNO
(
@CODIGO_ALUMNO INT,
@PARTIDA_DE_NACIMINETO CHAR(2),
@CERTIFICADO_NOTAS CHAR(2),
@TARJETA_VACUNA CHAR(2),
@CARTA_TRASLADO CHAR(2),
@FOTO IMAGE,
@CERTIFICADO_DE_SALUD CHAR(2)
)
AS
BEGIN
		BEGIN TRY
		DECLARE @DOCUMENTO_ALUMNO_ID INT
		SELECT @DOCUMENTO_ALUMNO_ID = ISNULL((DOCUMENTO_ALUMNO_ID),0)+1 FROM DOCUMENTOS_ALUMNOS
		INSERT INTO DOCUMENTOS_ALUMNOS VALUES
		(
			@DOCUMENTO_ALUMNO_ID,
            @CODIGO_ALUMNO,
            @PARTIDA_DE_NACIMINETO,
            @CERTIFICADO_NOTAS,
            @TARJETA_VACUNA,
            @CARTA_TRASLADO,
            @FOTO,
            @CERTIFICADO_DE_SALUD
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END
GO

--FUNCIONARIOS
CREATE PROC INSERTAR_FUNCIONARIO
(
@NOMBRE nvarchar(30),
@APELLIDO nvarchar(30),
@SEXO char (1),--F,M
@FECHA_NACIMIENTO DATE,
@CEDULA nvarchar(18),
@TELEFONO nvarchar(15),
@CARGO nvarchar(40),
@OCUPACION_ID INT,
@EMAIL nvarchar(60)
)
AS
BEGIN
		BEGIN TRY
		DECLARE @ID_FUNCIONARIO INT
		SELECT @ID_FUNCIONARIO = ISNULL(MAX(ID_FUNCIONARIO),0)+1 FROM FUNCIONARIOS
		INSERT INTO FUNCIONARIOS VALUES
		(
			@ID_FUNCIONARIO,
            @NOMBRE,
            @APELLIDO,
            @SEXO,
            @FECHA_NACIMIENTO,
            @CEDULA,
            @TELEFONO,
            @CARGO,
            @OCUPACION_ID,
            @EMAIL
		)
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
			ROLLBACK
		END CATCH
END
GO

CREATE PROC EDITAR_FUNCIONARIO
(
@ID_FUNCIONARIO INT,
@NOMBRE nvarchar(30),
@APELLIDO nvarchar(30),
@SEXO char (1),
@FECHA_NACIMIENTO DATE,
@CEDULA nvarchar(18),
@TELEFONO nvarchar(15),
@CARGO nvarchar(40),
@OCUPACION_ID INT,
@EMAIL nvarchar(60)
)
AS
BEGIN
		BEGIN TRY
		UPDATE FUNCIONARIOS  SET
            NOMBRE = @NOMBRE,
            APELLIDO = @APELLIDO,
            SEXO = @SEXO,
            FECHA_NACIMIENTO = @FECHA_NACIMIENTO,
            CEDULA = @CEDULA,
            TELEFONO = @TELEFONO,
            CARGO = @CARGO,
            OCUPACION_ID = @OCUPACION_ID,
            EMAIL = @EMAIL
			WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
			ROLLBACK
		END CATCH
END
GO

--USUARIOS
CREATE PROC INSERTAR_USUARIOS
(
@USUARIO_ID INT,
@USUARIO NVARCHAR(20),
@CONTRASEŅA NVARCHAR(200),
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
            HASHBYTES('SHA1',@CONTRASEŅA),
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

CREATE PROC EDITAR_CONTRASEŅA_USUARIO
(
@USUARIO_ID INT,
@CONTRASEŅA NVARCHAR(200)
)
AS
BEGIN
	BEGIN TRY 
		UPDATE USUARIOS SET
		CONTRASEŅA = @CONTRASEŅA
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
@CONTRASEŅA NVARCHAR(200),
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

--ASIGNATURAS
CREATE PROC INSERTAR_ASIGNATURAS
(
@NOMBRE NVARCHAR(50)
)
AS
BEGIN
		BEGIN TRY
		DECLARE @ID INT
		SELECT @ID = ISNULL (MAX(CODIGO_ASIGNATURA),0)+1 FROM ASIGNATURAS
		DECLARE @ACTIVO BIT
		SELECT @ACTIVO = 1
		DECLARE @MSG NVARCHAR(100)
		DECLARE @EXISTE NVARCHAR(50)

		IF EXISTS  (SELECT NOMBRE FROM ASIGNATURAS WHERE NOMBRE = @NOMBRE)
		BEGIN
			SET @MSG = 'REGISTRO YA EXISTO' 
		END
		ELSE
		BEGIN
			INSERT INTO ASIGNATURAS VALUES
			(
			@ID,
			@NOMBRE,
			@ACTIVO
			)
		END
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
		SELECT @MSG AS MENSAJE
END
GO

CREATE PROC EDITAR_ASIGNATURAS
(
@CODIGO_ASIGNATURA INT,
@NOMBRE NVARCHAR(50),
@ACTIVO BIT
)
AS
BEGIN
		BEGIN TRY
		
			UPDATE ASIGNATURAS  SET
			NOMBRE = @NOMBRE,
			ACTIVO = @ACTIVO
			WHERE CODIGO_ASIGNATURA = @CODIGO_ASIGNATURA
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END
GO
--TURNOS
CREATE PROC INSERTAR_TURNOS
(
@TURNO NVARCHAR(20),
@DESCRIPCION NVARCHAR(200)
)
AS
BEGIN
		BEGIN TRY
		DECLARE @ACTIVO BIT
		SELECT @ACTIVO = 1
		DECLARE @ID_TURNOS INT
		SELECT @ID_TURNOS = ISNULL((ID_TURNOS),0)+1 FROM TURNOS
		INSERT INTO TURNOS VALUES
		(
		@ID_TURNOS,
		@TURNO,
		@DESCRIPCION,
		@ACTIVO
		)
		END TRY
		BEGIN CATCH
				IF @@TRANCOUNT > 0
				ROLLBACK
		END CATCH
END
GO
CREATE PROC EDITAR_TURNOS
(
@ID_TURNOS INT,
@TURNO NVARCHAR(20),
@DESCRIPCION NVARCHAR(200),
@ACTIVO BIT
)
AS
BEGIN
		BEGIN TRY
		UPDATE TURNOS SET
		TURNO = @TURNO,
		DESCRIPCION = @DESCRIPCION,
		ACTIVO = @ACTIVO
		WHERE ID_TURNOS = @ID_TURNOS
		END TRY
		BEGIN CATCH
				IF @@TRANCOUNT > 0
				ROLLBACK
		END CATCH
END
GO

--AULAS
CREATE PROC INSERTAR_AULAS
(
@CODIGO_AULA INT,
@AULA NVARCHAR(30),
@CAPACIDAD INT,
@VACANTES INT,
@CODIGO_GRADO INT
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO AULAS VALUES
		(
		@CODIGO_AULA,
		@AULA,
		@CAPACIDAD,
		@VACANTES,
		@CODIGO_GRADO
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END


CREATE PROC INSERTAR_MATERIADOC
(
@CODIGO_MATERIA_DOCENTE INT,
@ID_FUNCIONARIO INT, 
@CODIGO_ASIGNATURA INT
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO MATERIA_DOCENTES VALUES
		(
		@CODIGO_MATERIA_DOCENTE,
		@CODIGO_ASIGNATURA,
		@ID_FUNCIONARIO
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END


CREATE PROC INSERTAR_MATERIADOC
(
@CODIGO_MATERIA_DOCENTE INT,
@ID_FUNCIONARIO INT, 
@CODIGO_ASIGNATURA INT
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO MATERIA_DOCENTES VALUES
		(
		@CODIGO_MATERIA_DOCENTE,
		@CODIGO_ASIGNATURA,
		@ID_FUNCIONARIO
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END


CREATE PROC INSERTAR_CICLO
(
@CODIGO_MATERIA_DOCENTE INT,
@ID_FUNCIONARIO INT, 
@CODIGO_ASIGNATURA INT
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO CICLO_ESCOLAR VALUES
		(
		@CODIGO_MATERIA_DOCENTE,
		@CODIGO_ASIGNATURA,
		@ID_FUNCIONARIO
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END


CREATE PROC INSERTAR_EVALUACIONES
(
@ID_EVALUACION INT,
@MES NVARCHAR(20),
@PARCIAL NVARCHAR(30),
@OBSERVACIONES NVARCHAR(300),
@ID_CICLO INT 
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO EVALUACIONES VALUES
		(
		@ID_EVALUACION,
		@MES,
		@PARCIAL,
		@OBSERVACIONES,
		@ID_CICLO
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END


CREATE PROC INSERTAR_NOTAS
(
        @ID_NOTAS INT,
        @CODIGO_ALUMNO INT,
        @CODIGO_MATERIA_DOCENTE INT,
        @ACUMULADO INT,
        @EXAMEN INT,
        @ID_EVALUACION INT,
        @OBSERVACION NVARCHAR(300)
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO NOTAS VALUES
		(
		@ID_NOTAS,
        @CODIGO_ALUMNO,
        @CODIGO_MATERIA_DOCENTE,
        @ACUMULADO,
        @EXAMEN,
        @ID_EVALUACION,
        @OBSERVACION
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END


CREATE PROC INSERTAR_MATRICULA
(
@CODIGO_MATRICULA INT,
@CODIGO_ALUMNO INT, 
@CODIGO_GRADO INT, 
@FECHA_MATRICULA DATE,
@REPITENTE CHAR(2), --SI,NO
@ID_TURNOS INT,
@USUARIO_ID INT
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO MATRICULA VALUES
		(
@CODIGO_MATRICULA,
@CODIGO_ALUMNO, 
@CODIGO_GRADO, 
@FECHA_MATRICULA,
@REPITENTE,
@ID_TURNOS,
@USUARIO_ID
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END


CREATE PROC INSERTAR_SERVICIOS
(
@SERVICIOS_ID INT,
@NOMBRE_SERVICIO NVARCHAR(100)
)
AS
BEGIN
		BEGIN TRY
		INSERT INTO SERVICIOS VALUES
		(
@SERVICIOS_ID,
@NOMBRE_SERVICIO
		)
		END TRY
		BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK
		END CATCH
END