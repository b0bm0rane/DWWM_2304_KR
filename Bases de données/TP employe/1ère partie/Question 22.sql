SELECT ENAME, JOB, PNAME 
FROM emp 
JOIN projet 
ON emp.projetno = projet.projetno
WHERE JOB = "MANAGER";