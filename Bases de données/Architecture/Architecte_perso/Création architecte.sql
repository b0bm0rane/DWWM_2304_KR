DROP DATABASE if EXISTS architecte;

CREATE DATABASE if NOT EXISTS architecte;

USE architecte;

CREATE TABLE if not exists employe 
(
	employe_matricule INT PRIMARY KEY, 
	employe_nom VARCHAR(50) NOT NULL, 
	employe_prenom VARCHAR(50) NOT NULL, 
	employe_date_embauche DATE NOT NULL, 
	fonction_id INT NOT NULL
);

CREATE TABLE if not EXISTS fonction 
(
	fonction_id int PRIMARY KEY, 
	fonction_nom VARCHAR(50) NOT NULL
);

CREATE TABLE if NOT EXISTS dessiner 
(
	employe_matricule INT NOT NULL, 
	projet_reference INT NOT NULL, 
	PRIMARY KEY (employe_matricule, projet_reference)
);

CREATE TABLE if not EXISTS maitre_ouvrage 
(
	maitre_ouvrage_reference INT PRIMARY KEY, 
	maitre_ouvrage_nom VARCHAR(50) NOT NULL, 
	maitre_ouvrage_telephone INT NOT NULL, 
	adresse_id INT NOT NULL
);

CREATE TABLE if not EXISTS projet 
(
	projet_reference INT PRIMARY KEY, 
	projet_date_depot DATE NOT NULL, 
	projet_date_remise_previsionnelle DATE NOT NULL, 
	projet_superficie_totale_en_m2 INT NOT NULL, 
	projet_superficie_batie_en_m2 INT NOT NULL, 
	projet_prix DECIMAL(10,0) NOT NULL, 
	projet_date_fin_realisation DATE NOT NULL,
	type_projet_id INT NOT NULL, 
	adresse_id INT NOT NULL, 
	employe_matricule INT NOT NULL, 
	maitre_ouvrage_reference INT NOT NULL
);

CREATE TABLE if not EXISTS adresse 
(
	adresse_id INT PRIMARY KEY, 
	adresse_numero_rue INT NOT NULL, 
	adresse_nom_rue VARCHAR(50) NOT NULL, 
	adresse_code_postal INT NOT NULL, 
	adresse_ville VARCHAR(50) NOT NULL, 
	adresse_pays VARCHAR(50) NOT NULL
);

CREATE TABLE if not EXISTS type_projet 
(
	type_projet_id INT PRIMARY KEY, 
	type_projet_nom VARCHAR(50) NOT NULL
);

CREATE TABLE if NOT EXISTS caracteriser
(
	projet_reference INT NOT NULL, 
	type_travaux_id INT NOT NULL, 
	PRIMARY KEY (projet_reference, type_travaux_id)
);

CREATE TABLE if not EXISTS type_travaux 
(
	type_travaux_id INT PRIMARY KEY, 
	type_travaux_nom VARCHAR(50) NOT NULL
);

ALTER TABLE employe
	ADD CONSTRAINT FK_employe_fonction FOREIGN KEY (fonction_id) REFERENCES fonction(fonction_id);

ALTER TABLE dessiner
	ADD CONSTRAINT FK_dessiner_employe FOREIGN KEY (employe_matricule) REFERENCES employe(employe_matricule),
	ADD CONSTRAINT FK_dessiner_projet FOREIGN KEY (projet_reference) REFERENCES projet(projet_reference);

ALTER TABLE projet
	ADD CONSTRAINT FK_projet_type_projet FOREIGN KEY (type_projet_id) REFERENCES type_projet(type_projet_id),
	ADD CONSTRAINT FK_projet_adresse FOREIGN KEY (adresse_id) REFERENCES adresse(adresse_id),
	ADD CONSTRAINT FK_projet_employe FOREIGN KEY (employe_matricule) REFERENCES employe(employe_matricule),
	ADD CONSTRAINT FK_projet_maitre_ouvrage FOREIGN KEY (maitre_ouvrage_reference) REFERENCES maitre_ouvrage(maitre_ouvrage_reference);

ALTER TABLE caracteriser
	ADD CONSTRAINT FK_caracteriser_type_travaux_1 FOREIGN KEY (projet_reference) REFERENCES projet(projet_reference),
	ADD CONSTRAINT FK_caracteriser_type_travaux_2 FOREIGN KEY (type_travaux_id) REFERENCES type_travaux(type_travaux_id);

ALTER TABLE maitre_ouvrage
	ADD CONSTRAINT FK_maitre_ouvrage_adresse FOREIGN KEY (adresse_id) REFERENCES adresse(adresse_id);