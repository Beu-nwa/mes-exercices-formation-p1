
select pt.person_id, pt.firstname, pt.lastname, pt.date_of_birth, ct.contact_id, ct.phone_number, ct.email, atb.address_id, atb.number, atb.road, atb.post_code, atb.town, atb.country from Contact_Table ct inner join Person_Table pt on ct.person_id = pt.person_id inner join Contact_Address_Table cat on cat.contact_id = ct.contact_id inner join Address_Table atb on atb.address_id = cat.address_id where ct.person_id = 2

--select * from Person_Table

--update person_table set firstname = 'test', lastname = 'test2' where person_id = 3

--select * from Person_Table

SELECT address_id, COUNT(contact_id) as nb_bind_contact
FROM Contact_Address_Table
where address_id = 3
GROUP BY address_id