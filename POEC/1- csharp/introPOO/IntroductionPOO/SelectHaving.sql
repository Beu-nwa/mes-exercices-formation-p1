-- filter les groupes de resultats
-- where met en oeuvre les conditions sur les colonnes selectionnées
-- là où having les conditions sur les grps crés par group by
select * from account

--requete pour regrouper les categories de services et n'avoir que les membres ayant plus de 3 entrées

--sans having
select  product_cd,
		count(product_cd) as nm_compte,
		sum(avail_balance) as somme_montant,
		avg(avail_balance) as moyenne_montant
from account
group by product_cd


-- avec having
select  product_cd,
		count(product_cd) as nm_compte,
		sum(avail_balance) as somme_montant,
		avg(avail_balance) as moyenne_montant
from account
group by product_cd
having count(product_cd) > 3

-- avec where
SELECT product_cd,
       COUNT(product_cd) as nm_compte,
       SUM(avail_balance) as somme_montant,
       AVG(avail_balance) as moyenne_montant
FROM account
WHERE (SELECT COUNT(product_cd) FROM account) > 3
GROUP BY product_cd

-- where filtre la bdd avant le groupe by
-- having apres...

select  product_cd,
		count(product_cd) as nm_compte,
		sum(avail_balance) as somme_montant,
		avg(avail_balance) as moyenne_montant
from account
where open_branch_id = 1
group by product_cd
