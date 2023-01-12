-- les fonctions d'agregations courantes: 
-- sum, avg, count, min, max
-- 

select * from account

select  product_cd,
		count(product_cd) as nm_compte,
		sum(avail_balance) as somme_montant,
		avg(avail_balance) as moyenne_montant
from account
group by product_cd