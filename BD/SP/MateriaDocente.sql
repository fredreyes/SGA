--Materia Docente 
create proc IngresarMateriaDocente
(
@FuncionarioId INT, 
@AsignaturaId INT,
@TurnoID int,
@Primaria bit,
@secundaria bit
)
as
begin
		begin try
		declare @MateriaDocenteId INT 
		select @MateriaDocenteId = ISNULL(max(MateriaDocenteId),0)+ 1 from dbd.MateriaDocente
		insert into dbd.MateriaDocente values
		(
			@MateriaDocenteId,
			@FuncionarioId, 
			@AsignaturaId,
			@TurnoID,
			@Primaria,
			@secundaria
		)
		end try
		begin catch
			if @@TRANCOUNT > 0
				rollback
		end catch
end
go

create proc ModificarMateriaDocente
(
@MateriaDocenteId INT,
@AsignaturaId INT,
@TurnoID int,
@Primaria BIT,
@secundaria BIT
)
as
begin
		begin try
		update dbd.MateriaDocente set		
			AsignaturaId = @AsignaturaId,
			TurnoID = @TurnoID,
			Primaria = @Primaria,
			Secundaria = @secundaria
		where MateriaDocenteId = @MateriaDocenteId
		end try
		begin catch
			if @@TRANCOUNT > 0
				rollback
		end catch
end
go

create proc EliminarMateriaDocente
(
@MateriaDocenteID int
)
as
begin
	delete dbd.MateriaDocente where MateriaDocenteId = @MateriaDocenteID
end
go
