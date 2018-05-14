use SGA
go
--Plan clase
create Proc IngresarPlanClase
(
@AsignaturaId int,
@GradoId int
)
as
begin
declare @PlanClase int
select @PlanClase = ISNULL(max(PlanClaseID),0) +1 from PlanClase 
declare @CicloEscolarID int
select @CicloEscolarID = (select CicloEscolarId from CicloEscolar where Activo = 1)

insert into PlanClase  values 
(
@PlanClase,
@AsignaturaId,
@GradoId,
@CicloEscolarID
)
end
go

create PROC ListaPlandeClase
as
begin
select PlanClaseID,PC.AsignaturaId,A.Asignatura,PC.GradoId,G.Grado,PC.CicloEscolarID,CE.Ciclo from PlanClase PC
inner join Asignaturas A ON PC.AsignaturaId = A.AsignaturaId
INNER JOIN Grados G ON PC.GradoId = G.GradoId
INNER JOIN CicloEscolar CE ON PC.CicloEscolarID = CE.CicloEscolarId
order by PC.GradoId 
end
go


--MOSTRAR HORARIO
select * from PlanClase PC
inner join 
(
select * from Asignaturas
where AsignaturaId in (select AsignaturaId from PlanClase where GradoId = 1)) a 
on PC.AsignaturaId = a.AsignaturaId
where GradoId = 1


