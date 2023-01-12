-- requete pour voir l'ensemble des champs cités de la table OFFICER
SELECT OFFICER_ID, FIRST_NAME, LAST_NAME FROM OFFICER
-- avec alias et aligné
-- SELECT Emp.EMP_ID,EMP.FIRST_NAME, Emp.LAST_NAME, Emp.DEPT_ID FROM EMPLOYEE Emp
-- avec alias v2
SELECT  Emp.EMP_ID,
		EMP.FIRST_NAME,
		Emp.LAST_NAME, 
		Emp.DEPT_ID 
FROM EMPLOYEE Emp
-- sans alias
SELECT  EMP_ID,
		FIRST_NAME,
		LAST_NAME, 
		DEPT_ID 
FROM EMPLOYEE
