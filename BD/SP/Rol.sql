use SGA
GO

create proc IngresarRoles
(
@Descripcion nvarchar(100),
@Matricula bit,
@Administracion bit,
@Funcionarios bit,
@Calificaciones bit
)
as
begin
declare @RolId int
select @RolId = ISNULL(max(RolId),0)+1 from Rol
	insert into Rol values
	(
	@RolId,
	@Descripcion,
	@Matricula,
	@Administracion,
	@Funcionarios,
	@Calificaciones
	)
end
go

create proc ModificarRoles
(
@RolId int,
@Descripcion nvarchar(100),
@Matricula bit,
@Administracion bit,
@Funcionarios bit,
@Calificaciones bit
)
as
begin
	update Rol set
	@Descripcion = Descripcion,
	Matricula = @Matricula,
	Administracion = @Administracion,
	Funcionarios = @Funcionarios,
	Calificaciones = @Calificaciones
	WHERE RolId = @RolId
end
go