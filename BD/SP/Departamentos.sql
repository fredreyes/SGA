USE SGA
go
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
