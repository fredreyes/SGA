use SGA
GO
--Evaluaciones
create proc InsertarEvaluaciones
(
@Mes NVARCHAR(20),
@Pacial NVARCHAR(30),
@Observaciones NVARCHAR(300),
@CicloEscolarId INT
)
as
begin
		declare @activo bit
		set @activo = 1
		insert into Evaluaciones
		values
		(
		@Mes,
		@Pacial,
		@Observaciones,
		@CicloEscolarId,
		@activo
		)
end
go

create proc EliminarEvaluaciones
(
@EvaluacionId INT
)
as
begin
		delete Evaluaciones
		where EvaluacionId = @EvaluacionId
end
go
