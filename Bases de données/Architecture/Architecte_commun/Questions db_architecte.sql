/* 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone commence par '04' */

SELECT client_ref, client_nom FROM clients WHERE client_telephone LIKE '04%';

/* 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers */

SELECT client_ref, client_nom, type_client_libelle FROM clients 
			JOIN type_clients ON type_clients.type_client_id = clients.type_client_id
			WHERE type_client_libelle = 'particulier';
			
/* 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers */

SELECT client_ref, client_nom, type_client_libelle FROM clients 
			JOIN type_clients ON type_clients.type_client_id = clients.type_client_id
			WHERE type_client_libelle <> 'particulier';
			
/* 4. Sélectionner les projets qui ont été livrés en retard */

SELECT projet_ref, projet_date_fin_prevue, projet_date_fin_effective FROM projets WHERE projet_date_fin_prevue < projet_date_fin_effective;

/* 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les projets 
    avec le nom du client et le nom de l'architecte associés au projet */
    
SELECT projet_date_depot, projet_date_fin_prevue, projet_superficie_totale, projet_superficie_batie, projet_prix, emp_nom FROM projets 
JOIN clients ON clients.client_ref = projets.client_ref 
JOIN employes ON employes.emp_matricule = projets.emp_matricule;
			
/* 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte */

USE db_architecte;

SELECT projet_date_depot, projet_date_fin_prevue, projet_date_fin_effective, projet_superficie_totale, projet_superficie_batie, projet_prix, emp_nom FROM projets 
JOIN participer ON participer.projet_ref = projets.projet_ref 
JOIN employes ON employes.emp_matricule = projets.emp_matricule;

/* 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associés et le prix moyen pratiqué */



/* 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la pls grande */



/* 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet. */



/* 10. Sélectionner les projets dont l'adresse est identique au client associé */