-- la fonction sum permet de calculer la somme totale d'un colonne contenanat des valeurs numériques

-- total de valeur des compte du client id 1
select sum(avail_balance) as somme_des_comptes
from account
where cust_id = 1

select cust_id, sum(avail_balance) as somme_des_comptes
from account
group by cust_id