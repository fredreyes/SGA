use SGA
go
--CICLO  ESCOLAR
create proc IngresarCicloEscolar
(
@Ciclo int,
@FechaInicio date,
@FechaFin date
)
as
begin
		declare @activo bit
		set @activo = 1
		insert into CicloEscolar values
		(
		@Ciclo,
		@FechaInicio,
		@FechaFin,
		@activo
		)
end
go

create proc ModificarCicloEscolar
(
@CicloEscolarId int,
@Ciclo int,
@FechaInicio date,
@FechaFin date,
@Activo bit
)
as
begin
		update CicloEscolar set
		Ciclo = @Ciclo,
		FechaInicio =@FechaInicio,
		FechaFin = @FechaFin,
		Activo = @activo
		where CicloEscolarId = @CicloEscolarId
end
go


create proc EliminarCicloEscolar
(
@CicloEscolarId int
)
as
begin
		delete CicloEscolar 
		where CicloEscolarId = @CicloEscolarId
end
go