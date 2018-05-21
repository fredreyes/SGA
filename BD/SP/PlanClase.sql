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
declare @CicloEscolar int
select @CicloEscolar = (select Ciclo from dba.Parametros where Descripcion = 'CicloAcademico' and Activo = 1)

insert into PlanClase  values 
(
@PlanClase,
@AsignaturaId,
@GradoId,
@CicloEscolar
)
end
go

create PROC ListaPlandeClase
as
begin
select PlanClaseID,PC.AsignaturaId,A.Asignatura,PC.GradoId,G.Grado, CicloEscolar from PlanClase PC
inner join dba.Asignaturas A ON PC.AsignaturaId = A.AsignaturaId
INNER JOIN dba.Grados G ON PC.GradoId = G.GradoId
order by PC.GradoId 
end
go


--MOSTRAR HORARIO
select * from PlanClase PC
inner join 
(
select * from dba.Asignaturas
where AsignaturaId in (select AsignaturaId from PlanClase where GradoId = 12)) a 
on PC.AsignaturaId = a.AsignaturaId
where GradoId = 12




