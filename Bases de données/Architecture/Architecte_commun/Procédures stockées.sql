USE db_architecte;



DROP PROCEDURE if EXISTS recherche_emp_architecte;
DROP PROCEDURE if EXISTS recherche_emp_par_fonction;
DROP PROCEDURE if EXISTS nombre_effectif_par_fonction;
DROP PROCEDURE if EXISTS liste_projets_pour_un_employe;
DROP PROCEDURE if EXISTS anciennete_employe;



-- Quels sont les noms, prenoms, matricules des architectes parmis les employes ? 

DELIMITER |

				CREATE PROCEDURE if NOT EXISTS recherche_emp_architecte()
				BEGIN
				SELECT emp_matricule, emp_nom, emp_prenom
				FROM employes
				JOIN fonctions ON fonctions.fonction_id = employes.fonction_id
				WHERE fonction_nom = 'architecte';
				END|

DELIMITER ;

CALL recherche_emp_architecte();

-- Renvoyer la liste des salaries pour une fonction donnee en parametre

DELIMITER |

				CREATE PROCEDURE if NOT EXISTS recherche_emp_par_fonction(IN p_fonction_nom VARCHAR(50))
				BEGIN
				SELECT employes.emp_nom, employes.emp_prenom, employes.emp_date_embauche FROM employes JOIN fonctions ON fonctions.fonction_id = employes.fonction_id
				WHERE fonctions.fonction_nom = p_fonction_nom;
				END|

DELIMITER ;

SET @fonction_nom := 'dessinateur';
CALL recherche_emp_par_fonction(@fonction_nom);

Renvoyer le nombre effectif en variable de sortie pour une fonction donnee en parametre

DELIMITER |

				CREATE PROCEDURE if NOT EXISTS nombre_effectif_par_fonction(IN p_fonction_nom VARCHAR(50), OUT p_nombre_effectif_par_fonction INT)
				BEGIN
				SELECT COUNT(employes.emp_matricule) INTO p_nombre_effectif_par_fonction FROM employes
				JOIN fonctions ON employes.fonction_id = fonctions.fonction_id
				WHERE fonctions.fonction_nom = p_fonction_nom;
				END|

DELIMITER ;

SET @fonction_nom := 'dessinateur';
CALL nombre_effectif_par_fonction(@fonction_nom, @nombre_effectif_par_fonction);
SELECT @nombre_effectif_par_fonction;

-- Creer une procedure stockee qui affiche la liste des projets (projet_ref, date de fin prevue, projet_prix) pour un nom d employe en entree

DELIMITER |

				CREATE PROCEDURE if NOT EXISTS liste_projets_pour_un_employe
				BEGIN
				
				END|

DELIMITER ;

-- Creer une proceduree stockee qui prend le nom d un salarie en entree et qui renvoie son anciennete en annees dans une variable (out)

DELIMITER |

				CREATE PROCEDURE if NOT EXISTS anciennete_employe
				BEGIN
				
				END|

DELIMITER ;