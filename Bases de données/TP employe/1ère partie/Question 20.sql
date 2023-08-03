CREATE VIEW question20 asemployequestion20
SELECT ENAME, JOB, DNAME, PNAME 
FROM emp 
join dept 
join projet
ON dept.deptno = emp.DEPTNO 
and emp.projetno = projet.projetno;