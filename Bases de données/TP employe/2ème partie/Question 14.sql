SELECT ENAME, TIMESTAMPDIFF(MONTH,HIREDATE, NOW()) 
AS "nb de mois depuis embauche" 
from emp;