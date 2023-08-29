DROP DATABASE if EXISTS db_pokemon;

CREATE DATABASE db_pokemon;

USE db_pokemon;

CREATE TABLE espece (
	espece_id INT, 
	espece_nom VARCHAR(50),
	PRIMARY KEY(espece_id)
);

CREATE TABLE type_pokemon (
	type_id INT, 
	type_nom VARCHAR(50), 
	PRIMARY KEY(type_id)
);

CREATE TABLE pokemon (
	pokemon_id INT, 
	pokemon_niveau INT, 
	pokemon_pv INT, 
	pokemon_xp INT, 
	pokemon_position_equipe INT, 
	pokemon_date_capture DATE, 
	fk_dresseur_id INT, 
	fk_espece_id INT, 
	PRIMARY KEY(pokemon_id)
);

CREATE TABLE dresseur (
	dresseur_id INT, 
	dresseur_nom VARCHAR(50), 
	PRIMARY KEY(dresseur_id)
);

CREATE TABLE type_objet (
	objet_id INT, 
	objet_nom VARCHAR(50), 
	PRIMARY KEY(objet_id)
);

CREATE TABLE typer (
	fk_espece_id INT, 
	fk_type_id INT, 
	PRIMARY KEY(fk_espece_id, fk_type_id)
);

CREATE TABLE posseder (
	fk_dresseur_id INT, 
	fk_objet_id INT, 
	quantite INT, 
	PRIMARY KEY(fk_dresseur_id, fk_objet_id)
);

-- 	CREATE TABLE posseder (
-- 	dresseur_id INT NOT NULL,
-- 	objet_id INT NOT NULL,
-- 	quantite INT NOT NULL,
-- 	PRIMARY KEY (dresseur_id, objet_id)
-- );
-- 
-- ALTER TABLE posseder
-- 	ADD CONSTRAINT fk_posseder_dresseur,
-- 	ADD CONSTRAINT fk_posseder_type_objet
-- ;
-- 
-- INSERT INTO posseder(dresseur_id, objet_id, quantite) VALUES
-- 	(1, 1, 10),
-- 	(1, 2, 5),
-- 	(2, 2, 5),
-- ;