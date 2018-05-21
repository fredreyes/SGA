use SGA
go
--Asignatura
create proc IngresarAsignatura
(
@Asignatura nvarchar(100)
)
as
begin
		declare @activo bit
		set @activo = 1
		insert into dba.Asignaturas values
		(
		@Asignatura,
		@activo
		)
end
go

create proc ModificarAsignatura
(
@AsignaturaId int,
@Asignatura nvarchar(100),
@activo bit
)
as
begin
		update dba.Asignaturas set
		Asignatura = @Asignatura,
		Activo = @activo
		where AsignaturaId = @AsignaturaId
end
go

create proc EliminarAsignatura
(
@AsignaturaId int
)
as
begin
		delete dba.Asignaturas
		where AsignaturaId = @AsignaturaId
end
go