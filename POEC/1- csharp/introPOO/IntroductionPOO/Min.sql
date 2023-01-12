select * from account

-- min retourne la plus petite valeur d'une colonne

select min(avail_balance) as solde_min
from account

select min(avail_balance) as solde_min_sav
from account
where product_cd = 'sav'

select open_branch_id,
min(avail_balance) as solde_min_de_la_branch
from account
group by open_branch_id

-- idem max()