/*1. Donner nom, job, numéro et salaire de tous les employés,
puis seulement des employés du département 10*/ 

/*SELECT ename, job, empno, sal FROM emp WHERE emp.deptno = 10;*/

/*2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800*/
/* SELECT ename, job, sal FROM emp WHERE job ='manager' AND sal > 2800;*/

/*3. Donner la liste des MANAGER n'appartenant pas au département 30*/

/*SELECT * FROM emp WHERE job ='manager' AND deptno<>30*/

/*4. Liste des employés de salaire compris entre 1200 et 1400*/

/*SELECT * FROM emp WHERE sal BETWEEN 1200 AND 1400; */

/*Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique*/
/*SELECT * FROM emp WHERE deptno IN(10,30,40) ORDER BY ename ASC;*/

/*Liste des employés du département 30 classés dans l'ordre des salaires croissants*/

/*  SELECT * FROM emp WHERE deptno= 30 order BY sal desc; */

/*Liste de tous les employés classés par emploi et salaires décroissants*/

/*SELECT * FROM emp ORDER BY job ASC, sal DESC;*/
 /* Liste des différents emplois*/
/*  SELECT DISTINCT job FROM emp ; */
 
 /*. Donner le nom du département où travaille ALLEN */
 
/* SELECT dept.DNAME FROM emp INNER JOIN dept ON emp.DEPTNO=dept.DEPTNO WHERE emp.ENAME='allen'*/
 
 /*10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par 
salaires décroissants.*/

/*SELECT dept.DNAME, emp.ename, emp.job, emp.sal FROM emp, dept WHERE  emp.DEPTNO=dept.DEPTNO  ORDER BY dept.DNAME , emp.sal DESC; */

/*1. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + 
commissions*/

/*SELECT ename, sal AS 'salaire fixe', comm , (sal+ IFNULL(comm,0)) AS  'salaire complet' FROM emp WHERE job ='salesman';*/

/*12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'*/

/*SELECT ename, job, DATE_FORMAT(HIREDATE,"%a %d %b %Y") AS 'date d\'embauche' FROM emp WHERE deptno=20; */
/*13. Donner le salaire le plus élevé par département*/

/*SELECT dept.DNAME, MAX(emp.sal) AS 'Salaire maximum' FROM emp INNER JOIN dept ON emp.deptno=dept.DEPTNO GROUP BY dept.DNAME  */
/*14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi*/
 
/*SELECT dept.DNAME, SUM(emp.sal) + SUM(IFNULL(emp.comm,0))  AS "masse salariale", COUNT(*) AS 'nombre d\'employe', AVG(emp.sal) AS 'Salaire moyen', emp.job 
FROM emp INNER JOIN dept ON emp.DEPTNO=dept.DEPTNO GROUP BY dept.DNAME, emp.job*/

/*15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés*/
/*SELECT dept.DNAME, SUM(emp.sal) + SUM(IFNULL(emp.comm,0))  AS "masse salariale", COUNT(*) AS 'nombre d\'employe', AVG(emp.sal) AS 'Salaire moyen', emp.job 
FROM emp INNER JOIN dept ON emp.DEPTNO=dept.DEPTNO GROUP BY dept.DNAME, emp.job HAVING( COUNT(*)>=2 );*/

/*16. Liste des employés (Nom, département, salaire) de même emploi que JONES*/ 

/*SELECT emp.ename, emp.JOB, dept.DNAME, emp.sal FROM emp,dept WHERE emp.deptno=dept.DEPTNO 
 AND emp.job =(SELECT emp.job FROM emp WHERE emp.ename="JONES") AND emp.ename!='JONES'*/
 
/* 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires*/
 
 /*SELECT job,ename, sal, (SELECT AVG(emp.sal) FROM emp) AS 'sal moyen global'
  FROM emp WHERE sal > (SELECT AVG(emp.sal) FROM emp)*/
 
 /*18. Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 
caractères), budget. Entrez les valeurs suivantes:
101, ALPHA, 96000
102, BETA,82000
103, GAMMA, 15000 */


/*CREATE TABLE projet ( projno INT NOT NULL PRIMARY KEY AUTO_INCREMENT, projname VARCHAR(5) NOT NULL, budget DECIMAL(11,2))*/
/*ALTER TABLE projet AUTO_INCREMENT=101;    */      

/*INSERT INTO projet VALUES (projno, 'ALPHA',96000 ),
									( projno,'BETA', 82000 ),
									(projno,'GAMMA', 15000);	*/
									
/*. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au 
projet 101, et les autres au projet 102 */
/*ALTER TABLE emp ADD COLUMN projno INT NOT NULL;*/   	
/*UPDATE emp SET projno=101 WHERE deptno=30 AND job ="salesman"; */
/*UPDATE emp SET projno=102 WHERE deptno<>30 OR  job<>"salesman";*/
/* ALTER TABLE emp ADD CONSTRAINT fk_projno FOREIGN KEY (projno) REFERENCES projet(projno);	*/

/*Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet*/

/*CREATE VIEW vue_employe AS SELECT ENAME, JOB, DNAME, projname 
FROM emp INNER JOIN dept INNER JOIN projet ON dept.DEPTNO=emp.DEPTNO AND emp.projno=projet.projno;	*/

/*A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom 
de projet triés sur nom de département et nom de projet		*/

/*SELECT * FROM vue_employe ORDER BY DNAME ASC , projname ASC; */

/* Donner le nom du projet associé à chaque manager*/

/*SELECT ENAME, JOB, projname FROM vue_employe WHERE JOB="MANAGER";	*/	
																		 