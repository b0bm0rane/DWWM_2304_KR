SELECT e.Ename, e.HIREDATE, m.ENAME 
AS manager_name, m.HIREDATE 
AS date_embauche_manager 
FROM emp e, emp m 
WHERE e.MGR = m.EMPNO AND e.HIREDATE < m.HIREDATE;