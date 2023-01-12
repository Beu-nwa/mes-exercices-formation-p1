-- Mise en forme et conversion INT  ->  VARCHAR
-- AS "nomColonne"

SELECT  EMP_ID,
		FIRST_NAME,
		LAST_NAME,
		DEPT_ID,
		'EMP : ' + Convert(VARCHAR, EMP_ID) AS EMPLOYEE_ID
FROM EMPLOYEE

