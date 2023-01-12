-- jointure externe pour recuperer toutes les infos de la table de droite

select * from customer
select * from officer

SELECT *
FROM customer cs
RIGHT JOIN officer ofc ON cs.cust_id = ofc.cust_id;