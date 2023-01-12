select * from acc_transaction
order by txn_id desc

--delete la 24 et la 26
delete from acc_transaction
where txn_id in (24, 26)

--delete de 10 à 12 donc 10,11,12
delete from acc_transaction
where txn_id
between 10
and 12

select * from acc_transaction
order by txn_id desc
