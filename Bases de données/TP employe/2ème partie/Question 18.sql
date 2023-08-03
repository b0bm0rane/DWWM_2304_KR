SELECT JOB, AVG(SAL) AS "salaire moyen" 
FROM emp 
GROUP BY JOB 
ORDER BY "salaire moyen" asc LIMIT 1;