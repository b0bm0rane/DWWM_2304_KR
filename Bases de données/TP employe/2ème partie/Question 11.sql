SELECT ENAME, JOB, MGR 
FROM emp 
WHERE JOB = (SELECT JOB FROM emp WHERE ENAME = "TURNER") 
AND (SELECT MGR FROM emp WHERE ENAME = "TURNER") 
AND ENAME != "TURNER";