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
					insert into dbd.ProfesionOcupacion
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
					update dbd.ProfesionOcupacion set
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
	delete dbd.ProfesionOcupacion where OcupacionId = @ocupacionId
end
go