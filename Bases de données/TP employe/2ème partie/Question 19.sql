SELECT DEPTNO, COUNT(*) AS nb_employe 
FROM emp 
GROUP BY DEPTNO 
ORDER BY nb_employe DESC LIMIT 1;