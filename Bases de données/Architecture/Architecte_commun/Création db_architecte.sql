DROP DATABASE IF EXISTS db_architecte;

CREATE DATABASE IF NOT EXISTS db_architecte;

USE db_architecte;

CREATE TABLE type_travaux(
   type_travaux_id INT AUTO_INCREMENT,
   type_travaux_libelle VARCHAR(50) NOT NULL,
   PRIMARY KEY(type_travaux_id),
   UNIQUE(type_travaux_libelle)
);

CREATE TABLE type_projets(
   type_projet_id INT AUTO_INCREMENT,
   type_projet_libelle VARCHAR(50) NOT NULL,
   PRIMARY KEY(type_projet_id),
   UNIQUE(type_projet_libelle)
);

CREATE TABLE adresses(
   adresse_id INT AUTO_INCREMENT,
   adresse_code_postal CHAR(5) NOT NULL,
   adresse_ville VARCHAR(50) NOT NULL,
   adresse_num_voie INT,
   adresse_voie VARCHAR(255) NOT NULL,
   PRIMARY KEY(adresse_id)
);

CREATE TABLE type_clients(
   type_client_id INT AUTO_INCREMENT,
   type_client_libelle VARCHAR(50) NOT NULL,
   PRIMARY KEY(type_client_id),
   UNIQUE(type_client_libelle)
);

CREATE TABLE fonctions(
   fonction_id INT AUTO_INCREMENT,
   fonction_nom VARCHAR(50) NOT NULL,
   PRIMARY KEY(fonction_id),
   UNIQUE(fonction_nom)
);

CREATE TABLE employes(
   emp_matricule INT AUTO_INCREMENT,
   emp_nom VARCHAR(50) NOT NULL,
   emp_prenom VARCHAR(50) NOT NULL,
   emp_date_embauche DATE NOT NULL,
   fonction_id INT NOT NULL,
   PRIMARY KEY(emp_matricule),
   FOREIGN KEY(fonction_id) REFERENCES fonctions(fonction_id)
);

CREATE TABLE clients(
   client_ref INT AUTO_INCREMENT,
   client_nom VARCHAR(50) NOT NULL,
   client_telephone CHAR(16) NOT NULL,
   type_client_id INT NOT NULL,
   adresse_id INT NOT NULL,
   PRIMARY KEY(client_ref),
   FOREIGN KEY(type_client_id) REFERENCES type_clients(type_client_id),
   FOREIGN KEY(adresse_id) REFERENCES adresses(adresse_id)
);

CREATE TABLE projets(
   projet_ref INT AUTO_INCREMENT,
   projet_date_depot DATE NOT NULL,
   projet_date_fin_prevue DATE NOT NULL,
   projet_date_fin_effective DATE,
   projet_superficie_totale INT NOT NULL,
   projet_superficie_batie INT NOT NULL,
   projet_prix DECIMAL(10,2) NOT NULL,
   client_ref INT NOT NULL,
   emp_matricule INT NOT NULL,
   adresse_id INT NOT NULL,
   type_travaux_id INT NOT NULL,
   type_projet_id INT NOT NULL,
   PRIMARY KEY(projet_ref),
   FOREIGN KEY(client_ref) REFERENCES clients(client_ref),
   FOREIGN KEY(emp_matricule) REFERENCES employes(emp_matricule),
   FOREIGN KEY(adresse_id) REFERENCES adresses(adresse_id),
   FOREIGN KEY(type_travaux_id) REFERENCES type_travaux(type_travaux_id),
   FOREIGN KEY(type_projet_id) REFERENCES type_projets(type_projet_id)
);

CREATE TABLE participer(
   emp_matricule INT,
   projet_ref INT,
   PRIMARY KEY(emp_matricule, projet_ref),
   FOREIGN KEY(emp_matricule) REFERENCES employes(emp_matricule),
   FOREIGN KEY(projet_ref) REFERENCES projets(projet_ref)
);
