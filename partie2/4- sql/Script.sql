drop table Contact_Table
drop table Address_Table
drop table Contact_Address_Table

CREATE TABLE Contact_Table (
  contact_id INT IDENTITY(1,1) NOT NULL,
  firstname varchar(50) NOT NULL,
  lastname varchar(50) NOT NULL,
  date_of_birth varchar(20) NOT NULL,
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
  contact_address_id INT IDENTITY(1,1) NOT NULL,
  contact_id INT NOT NULL,
  address_id INT NOT NULL,
PRIMARY KEY CLUSTERED (contact_address_id ASC)
);

INSERT INTO Contact_Table (firstname, lastname, date_of_birth, phone_number, email) VALUES
('John', 'Doe', '01/01/1970', '123-456-7890', 'john.doe@email.com'),
('Jane', 'Doe', '02/14/1980', '123-456-7891', 'jane.doe@email.com'),
('Bob', 'Smith', '03/21/1985', '123-456-7892', 'bob.smith@email.com'),
('Alice', 'Smith', '04/30/1990', '123-456-7893', 'alice.smith@email.com'),
('Eve', 'Johnson', '05/15/1995', '123-456-7894', 'eve.johnson@email.com');

INSERT INTO Address_Table (number, road, post_code, town, country) VALUES
('17', 'Main St', '12345', 'New York', 'USA'),
('82', 'Second Ave', '23456', 'Chicago', 'USA'),
('38', 'Third St', '34567', 'Los Angeles', 'USA'),
('45', 'Fourth Ave', '45678', 'Houston', 'USA'),
('57', 'Fifth St', '56789', 'Philadelphia', 'USA');

INSERT INTO Contact_Address_Table (contact_id, address_id) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

select * from Contact_Table
select * from Address_Table
select * from Contact_Address_Table