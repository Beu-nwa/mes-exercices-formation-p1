-- la fonction count permet d eretourner le nombre d eligne correspondant à nos requetes

select * from employee

select count(emp_id) as nb_employee
from employee

-------------------------------------------

select * from account

--compter le nombre de client unique qui détiennent au moins un compte
select count(distinct cust_id) as nb_client
from account

--requete pour lister les clients et leurs comtes
select cust_id, count(account_id) as nb_comptes
from account
group by cust_id