ALTER TABLE emp 
ADD COLUMN projetno INT 
NOT NULL;


UPDATE emp 
SET projetno = 101 
WHERE deptno = 30 
AND job = 'SALESMAN';


UPDATE emp 
SET projetno = 102 
WHERE empno 
NOT IN (SELECT empno FROM emp WHERE deptno = 30 AND job = 'SALESMAN');


UPDATE emp 
SET projetno = 102 
WHERE job != "SALESMAN";


ALTER TABLE emp 
ADD CONSTRAINT fk_projetno 
FOREIGN KEY (projetno) 
REFERENCES projet(projetno);