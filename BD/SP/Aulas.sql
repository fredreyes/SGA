use SGA
go
--AULAS
create proc IngresarAula
(
@Aula nvarchar(30),
@capacidad int,
@Vacantes int,
@GradoId int,
@Turno int
)
as
begin
		declare @activo bit
		set @activo = 1
		insert into dba.Aulas values
		(
		@Aula,
		@capacidad,
		@Vacantes,
		@GradoId,
		@Turno,
		@activo
		)
end
go


create proc ModificarAula
(
@AulaId int,
@Aula nvarchar(30),
@capacidad int,
@Vacantes int,
@GradoId int,
@Turno int,
@activo bit
)
as
begin
		update dba.Aulas set
		Aula = @Aula,
		Capacidad = @capacidad,
		Vacantes = @Vacantes,
		GradoId = @GradoId,
		TurnoId = @Turno,
		Activo = @activo
		where AulaId = @AulaId
end
go

create proc EliminarAulas
(
@AulaId int
)
as
begin
delete dba.Aulas where AulaId = @AulaId
end
go