SELECT emp.ENAME, emp.SAL 
FROM emp 
WHERE emp.SAL > (SELECT AVG(emp.SAL) FROM emp);