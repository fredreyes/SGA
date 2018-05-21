USE SGA
GO
--COLEGIO
create proc IngresarColegio
(
@Colegio nvarchar(100),
@Telefono nvarchar(20),
@DepartamentoId int
)
as
begin
		insert into dba.Colegio values
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
		update dba.Colegio set
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
delete dba.Colegio where ColegioId = @ColegioId
end
go
