Create database SGA
go
use SGA
go

--DEPARTAMENTOS
CREATE TABLE Departamentos
(
DepartamentoID int identity(1,1),
Departamento Nvarchar(150),
constraint pk_DepartamentoId Primary key (DepartamentoID)
)
GO
---TABLA COLEGIO
create table Colegio
(
ColegioId int not null identity(1,1),
Colegio nvarchar(100) not null,
Telefono nvarchar(20),
DepartamentoId int
constraint PK_Colegio primary key(ColegioId),
constraint fk_Departamento foreign key(DepartamentoId) references Departamentos(DepartamentoID)
)
go
--TABLA PROFESION_OCUPACION
create table ProfesionOcupacion
(
OcupacionId INT not null identity(1,1),
Ocupacion nvarchar(150) not null
constraint PK_Ocupacion primary key(OcupacionId)
)
go

--TABLA TURNOS
create table Turnos
(
TurnoId int NOT NULL identity(1,1),
Turno nvarchar(20) NOT NULL,
Descripcion nvarchar(200),
Activo bit
CONSTRAINT PK_TURNOS PRIMARY KEY(TurnoId)
)
GO
--TABLA GRADO
create table Grados
(
GradoId int NOT NULL identity(1,1),
Grado nvarchar(20) NOT NULL,
Tipo char (1),
Activo bit
CONSTRAINT PK_GRADO PRIMARY KEY(GradoId)
)
GO
--TABLA ASIGNATURA
create table Asignaturas
(
AsignaturaId int  NOT NULL identity(1,1),
Asignatura nvarchar(100) NOT NULL,
Activo bit
CONSTRAINT PK_ASIGNATURA PRIMARY KEY(AsignaturaId)
)
go
--CICLO_ESCOLAR
create table CicloEscolar
( 
CicloEscolarId INT NOT NULL identity(1,1),
Ciclo INT NOT NULL,
FechaInicio DATE NOT NULL,
FechaFin DATE NOT NULL,
Activo bit
CONSTRAINT PK_CICLO PRIMARY KEY(CicloEscolarId) 
)
GO

--TABLA AULAS
create table Aulas
(
AulaId INT NOT NULL identity(1,1),
Aula NVARCHAR(30) NOT NULL,
Capacidad INT NOT NULL CHECK(CAPACIDAD >= 0),
Vacantes INT NOT NULL CHECK(VACANTES >= 0),
GradoId INT NOT NULL,
Activo bit
CONSTRAINT PK_AULAS PRIMARY KEY(AulaId),
CONSTRAINT FK_AULAS_GRADOS FOREIGN KEY(GradoId) REFERENCES Grados(GradoId)
)
go
--TABLA EVALUACIONES
CREATE TABLE Evaluaciones
(
EvaluacionId INT NOT NULL identity(1,1),
Mes NVARCHAR(20) NOT NULL,
Pacial NVARCHAR(30) NOT NULL,
Observaciones NVARCHAR(300),
CicloEscolarId INT NOT NULL,
Activo bit
CONSTRAINT PK_EVALUACIONES PRIMARY KEY(EvaluacionId),
CONSTRAINT FK_EVALU_CICLO FOREIGN KEY(CicloEscolarId) REFERENCES CicloEscolar(CicloEscolarId)
)
GO


---------------------------------------------------
--TABLA ALUMNO
create table Alumnos
(
AlumnoId NVARCHAR(10) not null,
Nombre nvarchar(30) not null,
Apellido nvarchar(30) not null,
Sexo CHAR(1) not null,--F,M
FechaNacimiento DATE not null,
Direccion nvarchar(200) not null,
CodigoMined int not null,
Activo bit
constraint PK_Alumno primary key(AlumnoId)
)
go
--TABLA DOCUMENTO ALUMNO
CREATE TABLE DocumentosAlumnos
(
DocumentoId INT NOT NULL,
AlumnoId NVARCHAR(10) NOT NULL,-- REFERENCE ALUMNO
PartidaNaciminto CHAR(2), -- SI,NO
CertificadoNotas CHAR(2),
TarjetaVacuna CHAR(2),
CartaTraslado CHAR(2),
CertificadoSalud CHAR(2),
Foto IMAGE
CONSTRAINT PK_DOCUMENTOS PRIMARY KEY(DocumentoId),
CONSTRAINT FK_DOCUMENTOS_ALUMNOS FOREIGN KEY(AlumnoId) REFERENCES ALUMNOS(AlumnoId)
)
GO

--TABLA PARENTEZCO ALUMNO
create table PadresTutor
(
PadresTutorId INT not null,
AlumnoId NVARCHAR(10) not null,
NombresPadres nvarchar(200),
CedulaPadre NVARCHAR(18),
TelefonoPadre nvarchar(15),
EmailPadre NVARCHAR(100),
OcupacionPadre NVARCHAR(150),
NombresMadres nvarchar(200),
CedulaMadre NVARCHAR(18),
TelefonoMadre nvarchar(15),
EmailMadre NVARCHAR(100),
OcupacionMadre NVARCHAR(150),
NombreTutor NVARCHAR(150) Not null,
TelefonoTutor NVARCHAR(15)
CONSTRAINT PK_PADRE PRIMARY KEY(PadresTutorId),
CONSTRAINT FK_PADRES_ALUMNOS FOREIGN KEY(AlumnoId) REFERENCES Alumnos(AlumnoId)
)
GO

---TABLA FUNCIONARIO
CREATE TABLE Funcionarios
(
FuncionarioId INT not null identity(1,1),
Nombres nvarchar(100) not null,
Apellidos nvarchar(100) not null,
Cedula nvarchar(18) not null,
Sexo char (1) not null,--F,M
FechaNacimiento DATE not null,
Telefono nvarchar(15),
Cargo nvarchar(40) not null,
OcupacionId INT not null,
Email nvarchar(100),
Foto Image,
Activo Bit
constraint PK_Funcionario primary key(FuncionarioId),
constraint FK_Funcionario_Ocupacion foreign key(OcupacionId) references ProfesionOcupacion(OcupacionId)
)
go

--TABLA USUARIOS
CREATE TABLE UsuariosFuncionarios
(
UsuarioID INT NOT NULL,
Usuario NVARCHAR(50) NOT NULL,
Contrasenia NVARCHAR(200) NOT NULL,
Activo BIT,
FuncionarioId INT NOT NULL
CONSTRAINT PK_USUARIO PRIMARY KEY(UsuarioID),
CONSTRAINT FK_USUARIO_FUNCIONARIO FOREIGN KEY(FuncionarioId) REFERENCES FUNCIONARIOS(FuncionarioId)
)
GO

CREATE TABLE UsuariosAlumnos
(
UsuarioAlumno INT NOT NULL,
Usuario NVARCHAR(20) NOT NULL,
Contraseña NVARCHAR(200) NOT NULL,
Estado BIT,
AlumnoId NVARCHAR(10)
CONSTRAINT PK_USUARIO_ALUMNO PRIMARY KEY(UsuarioAlumno),
CONSTRAINT FK_USUARIO_ALUMNOS FOREIGN KEY(AlumnoId) REFERENCES ALUMNOS(AlumnoId)
)




--MATERIA_DOCENTES
CREATE TABLE MateriaDocente
(
MateriaDocenteId INT NOT NULL,
FuncionarioId INT NOT NULL, 
AsignaturaId INT
CONSTRAINT PK_MATERIADOCENTE PRIMARY KEY(MateriaDocenteId)
CONSTRAINT FK_MATE_FUNCIONARIO FOREIGN KEY(FuncionarioId) REFERENCES FUNCIONARIOS(FuncionarioId),
CONSTRAINT FK_MATE_ASIGNATURA FOREIGN KEY(AsignaturaId) REFERENCES ASIGNATURAS(AsignaturaId)
)
GO





--TABLA NOTAS
CREATE TABLE Calificaciones
(
CalificacionesId INT NOT NULL,
AlumnoId NVARCHAR(10) NOT NULL,
MateriaDocenteId INT NOT NULL,
Acumulado INT NOT NULL,
Examen INT NOT NULL,
Rescate int,
EvaluacionId INT NOT NULL,
Onservacion NVARCHAR(300)
CONSTRAINT PK_NOTAS PRIMARY KEY(CalificacionesId),
CONSTRAINT FK_NOTAS_ALUMNOS FOREIGN KEY(AlumnoId) REFERENCES ALUMNOS(AlumnoId),
CONSTRAINT FK_NOTAS_DOCENTEMATERIA FOREIGN KEY(MateriaDocenteId) REFERENCES MateriaDocente(MateriaDocenteId),
CONSTRAINT FK_NOTAS_EVALUCIONES FOREIGN KEY(EvaluacionId) REFERENCES EVALUACIONES(EvaluacionId)
)
GO

--TABLA MATRICULA
CREATE TABLE Matricula
( 
MatriculaId INT NOT NULL,
CicloEscolarId INT,
AlumnoId NVARCHAR(10) NOT NULL, 
GradoId INT NOT NULL, 
FechaMatricula DATE NOT NULL default GETDATE(),
Repitente CHAR(2) NOT NULL, --SI,NO
TurnoId INT NOT NULL,
ColegioId INT,
UsuarioId INT NOT NULL
CONSTRAINT PK_MATRICULA PRIMARY KEY(MatriculaId),
CONSTRAINT FK_MATRI_ALMNO FOREIGN KEY(AlumnoId) REFERENCES ALUMNOS(AlumnoId),
CONSTRAINT FK_MATRI_GRADO FOREIGN KEY(GradoId) REFERENCES GRADOS(GradoId),
CONSTRAINT FK_MATRI_TURNO FOREIGN KEY(TurnoId) REFERENCES TURNOS(TurnoId),
CONSTRAINT FK_MATRI_USUARIO FOREIGN KEY(UsuarioId) REFERENCES UsuariosFuncionarios(UsuarioId),
CONSTRAINT FK_MATRICULACICLO FOREIGN KEY(CicloEscolarId) REFERENCES CicloEscolar(CicloEscolarId),
CONSTRAINT FK_MATRICULACOLEGIO FOREIGN KEY(ColegioId) REFERENCES Colegio(ColegioId)
)
GO

----TABLA SERVICIOS
--CREATE TABLE SERVICIOS
--(
--SERVICIOS_ID INT NOT NULL,
--NOMBRE_SERVICIO NVARCHAR(100),
--DESCRIPCION NVARCHAR(300),
--CONSTRAINT PK_SERVICIO PRIMARY KEY(SERVICIOS_ID)
--)
--GO

----TABLA DETALLE_SERVICIOS
--CREATE TABLE DETALLE_SERVICIOS
--(
--ID_DETALLESERVICIO INT NOT NULL,
--SERVICIOS_ID INT NOT NULL,
--MONTO MONEY NOT NULL
--CONSTRAINT PK_DETALLESER PRIMARY KEY(ID_DETALLESERVICIO),
--CONSTRAINT FK_DETALLESER_SERV FOREIGN KEY(SERVICIOS_ID) REFERENCES SERVICIOS(SERVICIOS_ID)
--)
--GO

----TABLA UNIFORME
--CREATE TABLE UNIFORMES
--(
--UNIFORME_ID INT NOT NULL,
--NOMBRE_UNIFORME NVARCHAR(30),
--DESCRIPCION CHAR(1), --8,10,12,16,S,M//28
--CANTIDAD INT CHECK(CANTIDAD >= 0),
--RESTANTE INT CHECK(RESTANTE >=0),
--DISPONIBILIDAD BIT,
--PRECIO MONEY
--CONSTRAINT PK_UNIFORME PRIMARY KEY(UNIFORME_ID)
--)
--GO

----TABLA PAGO
--CREATE TABLE PAGO
--(
--ID_PAGO INT NOT NULL, 
--CODIGO_ALUMNO NVARCHAR(10) NOT NULL, 
--ID_DETALLESERVICIO INT NULL,
--UNIFORME_ID INT NULL,
--MES NVARCHAR(20),
--FECHA_PAGO DATE NOT NULL, 
--CANCELADO CHAR(1), --C,P
--USUARIO_ID INT NOT NULL
--CONSTRAINT PK_PAGO PRIMARY KEY(ID_PAGO),
--CONSTRAINT FK_PAGOALUMNO FOREIGN KEY(CODIGO_ALUMNO) REFERENCES ALUMNOS(CODIGO_ALUMNO),
--CONSTRAINT FK_PAGODETALLESER FOREIGN KEY(ID_DETALLESERVICIO) REFERENCES DETALLE_SERVICIOS(ID_DETALLESERVICIO),
--CONSTRAINT FK_PAGOUNIFOR FOREIGN KEY(UNIFORME_ID) REFERENCES UNIFORMES(UNIFORME_ID),
--CONSTRAINT FK_PAGOUSUARIO FOREIGN KEY(USUARIO_ID) REFERENCES USUARIOS(USUARIO_ID)
--)
--GO