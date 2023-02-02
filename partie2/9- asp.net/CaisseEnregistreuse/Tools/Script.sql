
CREATE TABLE category (
    id INT PRIMARY KEY,
    title VARCHAR(255)
);


CREATE TABLE product (
    id INT PRIMARY KEY,
    title VARCHAR(255),
    price DECIMAL(10,2),
    category_id INT,
    FOREIGN KEY (category_id) REFERENCES category(id)
);

INSERT INTO category (id, title)
VALUES
(1, 'Fruit'),
(2, 'Légume');

INSERT INTO product (id, title, price, category_id)
VALUES
(1, 'Fraise', 999.99, 1),
(2, 'Pomme', 159.99, 1),
(3, 'Panais', 69.99, 2);