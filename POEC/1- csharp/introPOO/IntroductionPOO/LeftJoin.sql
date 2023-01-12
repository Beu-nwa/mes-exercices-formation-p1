-- jointure externe pour recuperer toutes les infos de la table de gauche

select * from customer
select * from officer

SELECT *
FROM officer ofc
RIGHT JOIN customer cs ON cs.cust_id = ofc.cust_id;