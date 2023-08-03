/* corriger employe partie 2*/ 
 
 /*Afficher la liste des managers des départements 20 et 30*/
 
/*SELECT ENAME,JOB,DEPTNO FROM emp WHERE JOB="manager" HAVING DEPTNO=20 OR DEPTNO=30;*/

/*Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81*/

/*SELECT * FROM emp WHERE HIREDATE LIKE "1981%" AND  JOB<> "manager";*/

/*Afficher la liste des employés ayant une commission*/

/*SELECT * FROM emp WHERE comm IS NOT NULL;*/

/*Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de 
Département et JOB les derniers embauches d'abord*/

/*SELECT ENAME, DEPTNO, JOB, HIREDATE FROM emp ORDER  BY DEPTNO, JOB , HIREDATE DESC;*/

/*Afficher la liste des employés travaillant à DALLAS*/
/*SELECT * FROM emp INNER JOIN dept ON emp.DEPTNO=dept.DEPTNO WHERE dept.LOC = "dallas";

SELECT ENAME,JOB,DNAME,LOC FROM emp INNER JOIN dept ON emp.DEPTNO=dept.DEPTNO WHERE dept.LOC = "dallas";*/

/*Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date 
d'embauche du manager.*/

/*SELECT e.ENAME,e.HIREDATE, m.ENAME AS manager_name, m.HIREDATE AS date_empbauche_manager 
FROM emp e,emp m 
WHERE e.MGR=m.EMPNO AND e.HIREDATE<m.HIREDATE;*/

/*Lister les numéros des employés n'ayant pas de subordonné*/


/*SELECT empno, ename, job  FROM emp WHERE empno NOT IN(SELECT DISTINCT mgr from emp WHERE mgr IS NOT NULL );
 
 SELECT empno, ename , job FROM emp A WHERE NOT EXISTS(SELECT MGR FROM emp WHERE A.EMPNO= mgr);*/ 
 
 /* 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE*/
 
/*SELECT ename, hiredate FROM emp WHERE hiredate < (SELECT hiredate FROM emp WHERE ename='blake' );*/

/*9. Afficher les employés embauchés le même jour que FORD*/

/* SELECT ename, hiredate FROM emp WHERE hiredate=(SELECT hiredate FROM emp WHERE ename="ford") AND ename<>'ford';*/
 /*10. Lister les employés ayant le même manager que CLARK.*/
 
/*SELECT ename FROM emp WHERE  mgr=(SELECT mgr  FROM emp WHERE ename="clark") AND ename!='clark';*/  

/* 11. Lister les employés ayant même job et même manager que TURNER*/

/*SELECT ename, job,mgr 
FROM emp 
WHERE job=(SELECT job 
				FROM emp 
				WHERE ename ="turner") 
			AND mgr=( SELECT mgr 
							FROM emp 
							WHERE ename="turner") 
			AND ename<>'turner' */
			
/*12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département 
SALES.*/

/*SELECT ename FROM emp INNER JOIN dept ON emp.deptno=dept.DEPTNO
 WHERE dept.DNAME='RESEARCH' AND hiredate  IN (
SELECT hiredate FROM emp, dept WHERE  emp.deptno=dept.DEPTNO AND DNAME='SALES') 


SELECT ename FROM emp, dept 
 WHERE  emp.deptno=dept.DEPTNO AND  dept.DNAME='RESEARCH' AND hiredate  IN (
SELECT  hiredate FROM emp, dept WHERE  emp.deptno=dept.DEPTNO AND DNAME='SALES') */
/*13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche*/

/*Select ename,DAYNAME(hiredate) AS 'jour de la semaine' FROM emp;  */
/*14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date 
actuelle*/

/*SELECT ename, TIMESTAMPDIFF(MONTH,hiredate,NOW()) AS 'nb mois de puis embauche' FROM emp;*/

/*Afficher la liste des employés ayant un M et un A dans leur nom*/

/*SELECT ENAME FROM emp WHERE ENAME LIKE '%A%' AND ENAME  LIKE '%M%';*/

/*Afficher la liste des employés ayant deux 'A' dans leur nom.*/

/*SELECT ENAME FROM emp WHERE ENAME LIKE '%A%A%';*/

/*Afficher les employés embauchés avant tous les employés du département 10.*/

/* SELECT * ,(SELECT MIN(hiredate)  
 				FROM emp 
				 WHERE DEPTNO=10) AS 'date 10' 
 FROM emp 
 WHERE hiredate < (SELECT MIN(hiredate) 
 						FROM emp 
						 WHERE DEPTNO=10)*/
						 
/*. Sélectionner le métier où le salaire moyen est le plus faible*/

/*SELECT JOB,AVG(SAL) AS 'salaire moyen' FROM emp GROUP BY JOB ORDER BY 'salaire moyen' ASC LIMIT 1*/

/* langage sql server*/
/*SELECT JOB,AVG(SAL) FROM emp WHERE AVG(SAL) <= ALL(SELECT AVG(SAL) FROM emp GROUP BY JOB) GROUP BY JOB*/

/*19 -Sélectionner le département ayant le plus d'employés*/
/*SELECT DEPTNO,COUNT(*) AS nb_employe FROM emp GROUP BY DEPTNO ORDER BY nb_employe DESC LIMIT 1;  */


/*20. Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci-dessous
Département Répartition en % 
----------- ----------------
10 21.43 
20 35.71 
30 42.86*/

/*select emp.deptno, ROUND( COUNT(*) * 100 / (select COUNT(*) from emp),2) AS 'repartition d\'employé en pourcentage' from emp group by emp.deptno;*/




