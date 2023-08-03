SELECT dept.DNAME, SUM(emp.SAL)+SUM(IFNULL(emp.COMM,0)) AS "masse salariale", COUNT(*) AS "nb d\'employe", emp.JOB 
FROM emp 
INNER JOIN dept 
ON emp.DEPTNO = dept.DEPTNO 
GROUP BY dept.DNAME, emp.JOB ;