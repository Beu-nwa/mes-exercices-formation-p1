select * from acc_transaction

-- requete pour inserer une transaction dans la bdd
-- primarykey genereation automatique de l'id
-- curent_timestamp : retourne date et heure au moment de l'operation (sql server)

insert into acc_transaction
	(amount,
	funds_avail_date,
	txn_date,
	txn_type_cd,
	account_id,
	execution_branch_id,
	teller_emp_id)
values (180, --amount
		current_timestamp, -- funds_avail_date
		current_timestamp, -- txn_date
		'cdt', -- txn_type_cd
		4,  -- account_id
		Null, -- execution_branch_id
		Null) -- teller_emp_id

select * from acc_transaction

-- a revoir ???