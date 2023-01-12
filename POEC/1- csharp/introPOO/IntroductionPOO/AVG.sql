select * from account

select avg(avail_balance) as moyenne_des_comptes_sav
from account
where product_cd = 'sav'

select avg(avail_balance) as moyenne_des_comptes_branch_1
from account
where open_branch_id = 1
group by cust_id