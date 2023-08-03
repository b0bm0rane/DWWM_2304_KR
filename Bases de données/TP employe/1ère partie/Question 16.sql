SELECT emp.ENAME, emp.JOB, dept.DNAME, emp.SAL 
FROM emp, dept 
WHERE emp.DEPTNO = dept.DEPTNO 
AND emp.JOB = (SELECT emp.JOB FROM emp WHERE emp.ENAME = "JONES") 
AND emp.ENAME != "JONES";