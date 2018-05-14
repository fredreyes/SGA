use SGA
GO

create Proc LoginUsuario
(
@Usuario nvarchar(100),
@Password nvarchar(max)
)
as
begin
select UsuarioID,Usuario,Password,U.FuncionarioID,f.Nombres,f.Apellidos,u.RolId, r.descripcion,r.Matricula,r.Administracion,r.Funcionarios,r.Calificaciones,u.Activo from Usuarios U
inner join Funcionarios f on U.FuncionarioID = f.FuncionarioId
inner join Rol r on U.RolId = r.RolId
where Usuario = @Usuario and Password = HASHBYTES('SHA1',@Password) and u.Activo = 1
end
go


create proc IngresarUsuario
(
@Usuario nvarchar(100),
@Password nvarchar(max),
@FuncionarioID int,
@RolId int
)
as
begin
declare @msg int
declare @FechaCreacion date
set @FechaCreacion = GETDATE()
declare @UsuarioID int
declare @Activo bit
set @Activo = 1
select @UsuarioID = ISNULL(max(UsuarioID),0)+1 from Usuarios
	if exists (select Usuario from Usuarios where Usuario = @Usuario)
	begin
		set @msg = 'Nombre de Usuario ya existe'
	end
	else
	begin
		insert into Usuarios values
		(
		@UsuarioID,
		@Usuario,
		HASHBYTES('SHA1',@Password),
		@FuncionarioID,
		@FechaCreacion,
		@RolId,
		@Activo
		)
	set  @msg = ''
	end
	select @msg as Mensaje
end
go


create proc ModificarUsuario
(
@UsuarioId int,
@Usuario nvarchar(100),
@Password nvarchar(max),
@RolId int,
@Activo bit
)
as
begin
		update Usuarios set
		Usuario = @Usuario,
		RolId = @RolId,
		@Activo = @Activo
		where  UsuarioId  =	@UsuarioId
		if LEN(@Password) >0
		 update Usuarios set
		 Password = HASHBYTES('SHA1',@Password)
end
go

create trigger IngresarUser
on Alumnos  after insert
as
begin
declare @msg int
declare @userName nvarchar(100) =(select Nombres from inserted)
declare @Password nvarchar(max)
set @Password = '123'
declare @UserID int = (select AlumnoId from inserted)
declare @FechaCreacion date
set @FechaCreacion = GETDATE()
declare @UsuarioID int
declare @Activo bit
declare  @Tipo nvarchar(3)
set @Tipo = 'ETE' 
set @Activo = 1
select @UsuarioID = ISNULL(max(UsuarioID),0)+1 from Users
	if exists (select UserName,UserID from Users where UserName = @userName and UserID = @UserID)
	begin
		set @msg = 'Nombre de Usuario ya existe'
	end
	else
	begin
		insert into Users values
		(
		@UsuarioID,
		@userName,
		HASHBYTES('SHA1',@Password),
		@UserID,
		@FechaCreacion,
		@Tipo,
		@Activo
		)
	set  @msg = ''
	end
	select @msg as Mensaje
end
go

create Proc LoginUsers
(
@UsuarioID nvarchar(100),
@Password nvarchar(max)
)
as
begin
select 
UsuarioID,
'Nombres' = case
when a.Nombres IS NOT NULL THEN A.Nombres + ' '+ A.Apellidos 
else
F.Nombres + ' ' + F.Apellidos
end,
Password,
UserID,
Tipo 
from Users U 
LEFT join Alumnos A on U.UserID = A.AlumnoId
LEFT join Funcionarios F on U.UserID = F.FuncionarioId
where UserID = @UsuarioID and Password = HASHBYTES('SHA1',@Password)
end
go




