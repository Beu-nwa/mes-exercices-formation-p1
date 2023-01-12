drop table personnes

CREATE TABLE personnes(
   id INT IDENTITY(1,1) NOT NULL,
   title varchar(4) NOT NULL CHECK (title IN ('Mr', 'Mme', 'Mlle')),
   prenom varchar(30) NOT NULL,
   nom varchar(30) NOT NULL,
   email varchar(50) NOT NULL,
   telephone varchar(17) NOT NULL,
PRIMARY KEY CLUSTERED (Id ASC)
);


INSERT INTO personnes (title, prenom, nom, email, telephone)
VALUES ('Mr', 'John', 'Smith', 'john.smith@example.com', '123-456-7890');
INSERT INTO personnes (title, prenom, nom, email, telephone)
VALUES ('Mr', 'Benoit', 'Combe', 'benoit.combe@example.com', '213-456-7890');
INSERT INTO personnes (title, prenom, nom, email, telephone)
VALUES ('Mlle', 'Maxou', 'Letellier', 'maxou.letellier@example.com', '312-456-7890');
INSERT INTO personnes (title, prenom, nom, email, telephone)
VALUES ('Mme', 'Tata', 'Blanchouille', 'tata.blanchouille@example.com', '312-456-7890');

select * from personnes
select * from personnes order by nom asc
-- select * from personnes order by title asc
--filtrer par mail