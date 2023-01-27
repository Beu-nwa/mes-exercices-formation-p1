drop table person_table
drop table contact_Table
drop table address_Table
drop table contact_Address_Table

create table person_table
(
  person_id int identity(1,1) not null primary key,
  firstname varchar(50) NOT NULL,
  lastname varchar(50) NOT NULL,
  date_of_birth DATETIME NOT NULL,
)

CREATE TABLE Contact_Table (
  contact_id INT IDENTITY(1,1) NOT NULL,
  person_id int not null,
  -- firstname varchar(50) NOT NULL,
  -- lastname varchar(50) NOT NULL,
  -- date_of_birth varchar(20) NOT NULL,
  phone_number varchar(17) NOT NULL,
  email varchar(50) NOT NULL,
PRIMARY KEY CLUSTERED (contact_id ASC)
);

CREATE TABLE Address_Table (
  address_id INT IDENTITY(1,1) NOT NULL,
  number varchar(50) NOT NULL,
  road varchar(50) NOT NULL,
  post_code varchar(50) NOT NULL,
  town varchar(50) NOT NULL,
  country varchar(50) NOT NULL,
PRIMARY KEY CLUSTERED (address_id ASC)
);

CREATE TABLE Contact_Address_Table (
  --contact_address_id INT IDENTITY(1,1) NOT NULL,
  contact_id INT NOT NULL,
  address_id INT NOT NULL,
--PRIMARY KEY CLUSTERED (contact_address_id ASC)
);

INSERT INTO person_table (firstname, lastname, date_of_birth) VALUES
('John', 'Doe', '01/01/1970'),
('Jane', 'Doe', '02/14/1980'),
('Bob', 'Smith', '03/21/1985'),
('Alice', 'Smith', '04/30/1990'),
('Eve', 'Johnson', '05/15/1995');

INSERT INTO Contact_Table (person_id, phone_number, email) VALUES
(1, '123-456-7890', 'john.doe@email.com'),
(2, '123-456-7891', 'jane.doe@email.com'),
(3, '123-456-7892', 'bob.smith@email.com'),
(4, '123-456-7893', 'alice.smith@email.com'),
(5, '123-456-7894', 'eve.johnson@email.com');

INSERT INTO Address_Table (number, road, post_code, town, country) VALUES
('17', 'Main St', '12345', 'New York', 'USA'),
('38', 'Third St', '34567', 'Los Angeles', 'USA'),
('45', 'Fourth Ave', '45678', 'Houston', 'USA'),
('57', 'Fifth St', '56789', 'Philadelphia', 'USA');

INSERT INTO Contact_Address_Table (contact_id, address_id) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 4);

--select * from person_Table
--select * from Contact_Table
--select * from Address_Table
--select * from Contact_Address_Table

-- retourne toutes les  infos pour un new contact
select
pt.person_id,		--1
pt.firstname,		--2
pt.lastname,		--3
pt.date_of_birth,   --4
ct.contact_id,		--5
ct.phone_number,    --6
ct.email,			--7
atb.address_id,		--8
atb.number,			--9
atb.road,			--10
atb.post_code,	    --11
atb.town,			--12
atb.country			--13
from Contact_Table ct
inner join Person_Table pt
on ct.person_id = pt.person_id
inner join Contact_Address_Table cat
on cat.contact_id = ct.contact_id
inner join Address_Table atb
on atb.address_id = cat.address_id
-- where ct.person_id = 2 -- en fonction de l

---- delete dans contact_table et address_contact_table
--DELETE FROM Contact_Table WHERE contact_id = 2;
--DELETE FROM Contact_Address_Table WHERE contact_id = 2;
--DELETE FROM Address_Table WHERE address_id IN
--(
--	SELECT address_id FROM Contact_Address_Table WHERE contact_id = 2
--);

---- tout delete
--DELETE FROM Contact_Table WHERE contact_id = 2;
--DELETE FROM Person_Table WHERE person_id = 2;
--DELETE FROM Contact_Address_Table WHERE contact_id = 2;
--DELETE FROM Address_Table WHERE address_id = 2;




--INSERT INTO person_table (firstname, lastname, date_of_birth) VALUES ('test', 'test', '01/01/1970');
--INSERT INTO Contact_Table (person_id, phone_number, email) VALUES (6, '123-456-7890', 'test.test@email.com');
--INSERT INTO Address_Table (number, road, post_code, town, country) VALUES ('00', 'Main St', '12345', 'test_cambrai', 'USA');

select * from person_Table
select * from Contact_Table
select * from Address_Table
select * from Contact_Address_Table

-- compter le nombre de contact lier à une adresse
SELECT address_id, COUNT(contact_id) as nb_bind_contact
FROM Contact_Address_Table
where address_id = 1
GROUP BY address_id
-- HAVING COUNT(contact_id) > 1;

--SELECT * FROM Address_Table
--WHERE number = '38' AND road = 'Third St' AND post_code = '34567' AND town = 'Los Angeles' AND country = 'USA'