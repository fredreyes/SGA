Create database SGA
go
use SGA
go

--esquema de administracion
create schema dba
go
--esquema de Docentes
create schema dbd
go
-----------------/**********esquema de Administracion*************************/--------------
--Parametros
CREATE TABLE dba.Parametros
(
ParametroID int identity(1,1),
Descripcion nvarchar(200),
Ciclo int,
Activo bit
)
go

--DEPARTAMENTOS
CREATE TABLE dba.Departamentos
(
DepartamentoID int identity(1,1),
Departamento Nvarchar(150) unique,
constraint pk_DepartamentoId Primary key (DepartamentoID)
)
GO
---TABLA COLEGIO
create table dba.Colegio
(
ColegioId int not null identity(1,1),
Colegio nvarchar(100) not null,
Telefono nvarchar(20),
DepartamentoId int
constraint PK_Colegio primary key(ColegioId),
constraint fk_Departamento foreign key(DepartamentoId) references dba.Departamentos(DepartamentoID)
)
go

--TABLA TURNOS
create table dba.Turnos
(
TurnoId int NOT NULL identity(1,1),
Turno nvarchar(20) NOT NULL unique,
Descripcion nvarchar(200),
Activo bit
CONSTRAINT PK_TURNOS PRIMARY KEY(TurnoId)
)
GO
--TABLA GRADO
create table dba.Grados
(
GradoId int NOT NULL identity(1,1),
Grado nvarchar(20) NOT NULL,
Tipo char (1),
Activo bit
CONSTRAINT PK_GRADO PRIMARY KEY(GradoId)
)
GO
--TABLA ASIGNATURA
create table dba.Asignaturas
(
AsignaturaId int  NOT NULL identity(1,1),
Asignatura nvarchar(100) NOT NULL,
Activo bit
CONSTRAINT PK_ASIGNATURA PRIMARY KEY(AsignaturaId)
)
go

--TABLA AULAS
create table dba.Aulas
(
AulaId INT NOT NULL identity(1,1),
Aula NVARCHAR(30) NOT NULL,
Capacidad INT NOT NULL CHECK(CAPACIDAD >= 0),
Vacantes INT NOT NULL CHECK(VACANTES >= 0),
GradoId INT NOT NULL,
TurnoId int not null,
Activo bit
CONSTRAINT PK_AULAS PRIMARY KEY(AulaId),
CONSTRAINT FK_AULAS_GRADOS FOREIGN KEY(GradoId) REFERENCES dba.Grados(GradoId),
CONSTRAINT FK_AULAS_TURNOS FOREIGN KEY(TurnoId) REFERENCES dba.Turnos(TurnoId)
)
go

-----------------/**********esquema de Administracion*************************/--------------
--TABLA PROFESION_OCUPACION
create table dbd.ProfesionOcupacion
(
OcupacionId INT not null identity(1,1),
Ocupacion nvarchar(150) not null
constraint PK_Ocupacion primary key(OcupacionId)
)
go

create table dbd.Funcionarios
(
FuncionarioId INT not null identity(1,1),
Nombres nvarchar(100) not null,
Apellidos nvarchar(100) not null,
Cedula nvarchar(18) ,
Sexo char (1),--F,M
FechaNacimiento DATE check (FechaNacimiento <= Getdate()),
Telefono nvarchar(15),
Cargo nvarchar(40) ,
OcupacionId INT,
Email nvarchar(100),
Foto Image,
Activo Bit,
IsDocente bit
constraint PK_Funcionario primary key(FuncionarioId),
constraint FK_Funcionario_Ocupacion foreign key(OcupacionId) references dbd.ProfesionOcupacion(OcupacionId)
)
go

create table dbd.HistorialCargoFuncionaario
(
HistarialCargoID int identity(1,1),
FuncionarioID int,
Cargo nvarchar(40),
FechadeCambio date,
)
go

--MATERIA_DOCENTES
CREATE TABLE dbd.MateriaDocente
(
MateriaDocenteId INT NOT NULL,
FuncionarioId INT NOT NULL, 
AsignaturaId INT,
Mañana bit,
Tarde bit,
Primaria bit,
Secundaria bit
CONSTRAINT PK_MATERIADOCENTE PRIMARY KEY(MateriaDocenteId)
CONSTRAINT FK_MATE_FUNCIONARIO FOREIGN KEY(FuncionarioId) REFERENCES dbd.FUNCIONARIOS(FuncionarioId),
CONSTRAINT FK_MATE_ASIGNATURA FOREIGN KEY(AsignaturaId) REFERENCES dba.ASIGNATURAS(AsignaturaId)
)
GO

--Carga Academica Docente
create table dbd.CargaAcademicaDocente
(
CargaId int primary key identity(1,1),
FuncionarioId int,
AsingaturaId int,
GradoId int,
CicloEscolar int,
TurnoID int
)
go
--CICLO_ESCOLAR
--create table CicloEscolar
--( 
--CicloEscolarId INT NOT NULL identity(1,1),
--Ciclo INT NOT NULL,
--FechaInicio DATE NOT NULL,
--FechaFin DATE NOT NULL,
--Activo bit
--CONSTRAINT PK_CICLO PRIMARY KEY(CicloEscolarId) 
--)
--GO

--TABLA EVALUACIONES
CREATE TABLE Evaluaciones
(
EvaluacionId INT NOT NULL identity(1,1),
Mes NVARCHAR(20) NOT NULL,
Pacial NVARCHAR(30) NOT NULL,
Observaciones NVARCHAR(300),
CicloAcademico INT NOT NULL,
Activo bit
CONSTRAINT PK_EVALUACIONES PRIMARY KEY(EvaluacionId)
)
GO

--TABLA ALUMNO
create table Alumnos
(
AlumnoId int not null,
Nombres nvarchar(30) not null,
Apellidos nvarchar(30) not null,
Sexo CHAR(1) not null,--F,M
FechaNacimiento DATE not null,
Direccion nvarchar(200) not null,
CodigoMined int not null,
Activo bit
constraint PK_Alumno primary key(AlumnoId)
)
go

--TABLA PARENTEZCO ALUMNO
create table PadresTutorAlumno
(
PadresTutorId INT not null,
AlumnoId int not null,
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
CONSTRAINT PK_PADRE PRIMARY KEY(PadresTutorId),
CONSTRAINT FK_PADRES_ALUMNOS FOREIGN KEY(AlumnoId) REFERENCES Alumnos(AlumnoId)
)
GO

create table AlumnosTutor
(
TutorAlumnoID int,
AlumnoId int,
NombreTutor NVARCHAR(150),
CedulaTutor NVARCHAR(16),
TelefonoTutor NVARCHAR(15),
ParentezcoAlumno NVARCHAR(50),
)

--TABLA DOCUMENTO ALUMNO
CREATE TABLE DocumentosAlumnos
(
DocumentoId INT NOT NULL,
AlumnoId int NOT NULL,
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

-- Plan Clase Grados
create table  PlanClase
(
PlanClaseID int,
AsignaturaId int,
GradoId int,
CicloEscolar int
)
go

--TABLA MATRICULA
CREATE TABLE Matricula
( 
MatriculaId INT NOT NULL,
CicloEscolar INT,
AlumnoId int NOT NULL, 
GradoId INT NOT NULL, 
Seccion nvarchar(10),
FechaMatricula DATE NOT NULL,
Repitente CHAR(2) NOT NULL, --SI,NO
TurnoId INT NOT NULL,
ColegioId INT
CONSTRAINT PK_MATRICULA PRIMARY KEY(MatriculaId),
CONSTRAINT FK_MATRI_ALMNO FOREIGN KEY(AlumnoId) REFERENCES ALUMNOS(AlumnoId),
CONSTRAINT FK_MATRI_GRADO FOREIGN KEY(GradoId) REFERENCES dba.Grados(GradoId),
CONSTRAINT FK_MATRI_TURNO FOREIGN KEY(TurnoId) REFERENCES dba.Turnos(TurnoId)
)
GO



--Roles
Create table Rol
(
RolId int primary key,
Descripcion nvarchar(100),
Matricula bit,
Administracion bit,
Funcionarios bit,
Calificaciones bit
)
go
-- Usuarios del Sistema

Create table Usuarios
(
UsuarioID int,
Usuario nvarchar(100),
Password nvarchar(max),
FuncionarioID int,
FechaCreacion date,
RolId int,
Activo bit
CONSTRAINT pK_usuario PRIMARY KEY(Usuario),
CONSTRAINT fk_uSUARIO_Rol FOREIGN KEY(RolId) REFERENCES Rol(RolId),
CONSTRAINT fk_uSUARIO_Funcioarios FOREIGN KEY(FuncionarioID) REFERENCES dbd.Funcionarios(FuncionarioID),
)
go

--Usuarios Alumnos y Docentes
Create table Users
(
UsuarioID int,
UserID int,
UserName nvarchar(100),
Password nvarchar(max),
FechaCreacion date,
Tipo nvarchar(3),
Activo bit
CONSTRAINT pK_Users PRIMARY KEY(UserID)
)
go

--Calificaciones
--CREATE TABLE Calificaciones
--(
--CalificacionesId INT NOT NULL,
--AlumnoId int NOT NULL,
--MateriaDocenteId INT NOT NULL,
--Acumulado INT NOT NULL,
--Examen INT NOT NULL,
--Rescate int,
--EvaluacionId INT NOT NULL,
--Observacion NVARCHAR(300)
--CONSTRAINT PK_NOTAS PRIMARY KEY(CalificacionesId),
--CONSTRAINT FK_NOTAS_ALUMNOS FOREIGN KEY(AlumnoId) REFERENCES ALUMNOS(AlumnoId),
--CONSTRAINT FK_NOTAS_DOCENTEMATERIA FOREIGN KEY(MateriaDocenteId) REFERENCES MateriaDocente(MateriaDocenteId),
--CONSTRAINT FK_NOTAS_EVALUCIONES FOREIGN KEY(EvaluacionId) REFERENCES EVALUACIONES(EvaluacionId)
--)
--GO

---TABLA PAGO
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

