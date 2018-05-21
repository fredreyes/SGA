use SGA
go
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
		insert into dba.Grados 
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
	update dba.Grados 
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
	delete dba.Grados where GradoId  = @GradoId
end
go
