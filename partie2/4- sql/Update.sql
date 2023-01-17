select  account_id,
		product_cd,
		avail_balance,
		pending_balance,
		cust_id
from account
where cust_id = 1

update account 
set avail_balance = avail_balance*100/105,
pending_balance = pending_balance*100/105
where cust_id = 1

select  account_id,
		product_cd,
		avail_balance,
		pending_balance,
		cust_id
from account
where cust_id = 1

-- a revoir