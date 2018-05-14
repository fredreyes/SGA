use SGA
go
create proc BuscarAsignaturaPorGrados
(
@GradoId int
)
as
begin
SELECT PlanClaseID,PC.AsignaturaId,A.Asignatura,PC.GradoId,CicloEscolarID FROM PlanClase PC
left join Grados G on PC.GradoId = G.GradoId
left join Asignaturas A on PC.AsignaturaId = A.AsignaturaId
where pc.GradoId = @GradoId
end
go


create proc BuscarDocenePorAsignatura
(
@Asignatura int
)
as
begin
select Nombres,Apellidos,Asignatura,md.FuncionarioId from MateriaDocente md
inner join Funcionarios f on md.FuncionarioId = f.FuncionarioId
left join Asignaturas a on md.AsignaturaId = a.AsignaturaId
WHERE md.AsignaturaId = @Asignatura
end
go
--CargaAcademicaDocente
create Proc InsertarCargaAcademicaDocente
(
@FuncionarioId int,
@AsingaturaId int,
@GradoId int,
@CicloEscolarID int,
@TurnoID int
)
as 
begin
insert into CargaAcademicaDocente
values
(
@FuncionarioId,
@AsingaturaId,
@GradoId,
@CicloEscolarID,
@TurnoID
)
end
go
