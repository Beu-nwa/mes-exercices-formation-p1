SELECT * FROM PRODUCT

-- requete sur la table product pour trouver un certian type de produit loan
SELECT * 
FROM PRODUCT
WHERE PRODUCT_TYPE_CD = 'ACCOUNT'
-- name != auto loan
SELECT * 
FROM PRODUCT
WHERE NAME != 'auto loan'
-- id >= 5
SELECT * 
FROM EMPLOYEE
WHERE EMP_ID >= 5
-- starting from letter
SELECT * 
FROM EMPLOYEE 
WHERE FIRST_NAME LIKE 'jo%';
-- ending from letter
SELECT * 
FROM EMPLOYEE 
WHERE FIRST_NAME LIKE '%a';
-- contains letter
SELECT * 
FROM EMPLOYEE 
WHERE FIRST_NAME LIKE '%a%';
-- contains multiple letter
SELECT * 
FROM EMPLOYEE 
WHERE FIRST_NAME LIKE '%a%'
AND FIRST_NAME LIKE '%e%';

-- 2 conditions
SELECT * 
FROM EMPLOYEE 
WHERE EMP_ID >= 6
AND FIRST_NAME LIKE 'j%';