-- retourne les enregistrmeents qui ont au moins une ligne dans les 2 tables

-- exemple
--select * from tablea
--inner join tableb
--on tablea.id = tableb.nomcolonne

select * from employee
select * from department

-- on veut lier les 2 tableaux grace au dept_id

select  emp.EMP_ID,
		emp.FIRST_NAME,
		emp.TITLE,
		dpt.NAME as dpt_name
from employee emp
inner join department dpt
on emp.dept_id = dpt.dept_id

