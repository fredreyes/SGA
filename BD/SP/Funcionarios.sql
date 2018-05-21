use SGA
go
--FUNCIONARIOS
alter PROC IngresarFuncioarios
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
		insert into dbd.Funcionarios values
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
		if @IsDocente = 1
		begin
		declare @msg int
		declare @UsuarioID int
		declare @UserID int
		declare @Password nvarchar(max)
		set @Password = '123'
		declare @FechaCreacion date
		set @FechaCreacion = GETDATE()
		declare  @Tipo nvarchar(3)
		set @Tipo = 'DCT' 
		set @UserID = (select  top 1 FuncionarioId from dbd.Funcionarios order by  FuncionarioId desc)
		select @UsuarioID = ISNULL(max(UsuarioID),0)+1 from Users
			if exists (select UserName,UserID from Users where UserName = @Nombres+@Apellidos and UserID = @UserID )
			begin
				set @msg = 'Nombre de Usuario ya existe'
			end
			else
			begin
				insert into Users values
				(
				@UsuarioID,
				@UserID,
				@Nombres+@Apellidos,
				HASHBYTES('SHA1',@Password),
				@FechaCreacion,
				@Tipo,
				@Activo
				)
			set  @msg = ''
			end
			select @msg as Mensaje
		end
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
		update dbd.Funcionarios set
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
on dbdFuncionarios after update,insert
as
begin
declare @FuncionarioId int = (select FuncionarioId from inserted)
declare @Cargo nvarchar(100) = (select Cargo from dbd.Funcionarios where FuncionarioId = @FuncionarioId)
declare  @Fecha date = getdate()
		if @FuncionarioId is null
		begin
				insert into dbd.HistorialCargoFuncionaario values
				(
				@FuncionarioId,
				@Cargo,
				@Fecha
				)
		end
		else
		begin
		insert into dbd.HistorialCargoFuncionaario values
				(
				@FuncionarioId,
				@Cargo,
				@Fecha
				)
		end
end
go


