use SGA
GO
--PROFESION OCUPACION
create proc InsertarOcupacion
(
@Ocupacion nvarchar (150)
)
as
begin
	begin try
					insert into ProfesionOcupacion
					values
					(
					@Ocupacion
					)
		end try
		begin catch
			if @@TRANCOUNT > 0
		rollback
		end catch
end
go
CREATE PROC EditarOcupacion
(
@OcupacionId int,
@Ocupacion nvarchar (150)
)
as
begin
		begin try
					update ProfesionOcupacion set
					Ocupacion = @Ocupacion
					where  @OcupacionId = OcupacionId
		end try
		begin catch
			if @@TRANCOUNT > 0
		rollback
		end catch
end
go
create proc eliminarOcupacion
(
@ocupacionId int
)
as
begin
	delete ProfesionOcupacion where OcupacionId = @ocupacionId
end
go