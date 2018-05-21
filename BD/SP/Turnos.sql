use SGA
go
--TURNOS
create proc InsertarTurnos
(
@Turno nvarchar(200),
@Descripcion nvarchar(200)
)
as
begin
		declare @activo bit
		set @activo = 1		
		insert into dba.Turnos
		values
		(
		@Turno,
		@Descripcion,
		@activo
		)
end
go

create proc ModificarTurnos
(
@TurnoId int,
@Turno nvarchar(200),
@Descripcion nvarchar(200),
@Activo bit
)
as
begin
		update dba.Turnos set
		Turno = @Turno,
		Descripcion = @Descripcion,
		Activo = @activo
		where TurnoId = @TurnoId
end
GO
create proc eliminarTurno
(
@TurnoId int
)
as
begin
	delete dba.Turnos where TurnoId = @TurnoId
end
GO
