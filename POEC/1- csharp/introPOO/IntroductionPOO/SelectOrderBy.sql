SELECT  EMP_ID,
		FIRST_NAME,
		LAST_NAME,
		START_DATE,
		Convert(VARCHAR, START_DATE, 106) AS START_DATE_CONVERT
FROM EMPLOYEE
WHERE START_DATE
BETWEEN CONVERT(datetime, '01 may 2002', 106)
and convert(datetime, '30 sep 2002', 106)
order by start_date

-- décroissant
SELECT  EMP_ID,
		FIRST_NAME,
		LAST_NAME,
		START_DATE,
		Convert(VARCHAR, START_DATE, 106) AS START_DATE_CONVERT
FROM EMPLOYEE
WHERE START_DATE
BETWEEN CONVERT(datetime, '01 may 2002', 106)
and convert(datetime, '30 sep 2002', 106)
order by start_date desc

-- ranger de maniere croissante le product type mais decroissant le name
select product_cd, product_type_cd, name
from product
order by PRODUCT_type_CD asc, name desc