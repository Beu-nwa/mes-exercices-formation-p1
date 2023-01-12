select * from account

insert into acc_transaction
	(amount,
	funds_avail_date,
	txn_date,
	txn_type_cd,
	account_id,
	execution_branch_id,
	teller_emp_id)
select  avail_balance, -- amount
		last_activity_date, -- funds_avail_date
		open_date, -- txn_date
		'cdt', --txn_type_cd
		account_id,
		null,
		null
from account
where product_cd = 'CD'

-- a revoir