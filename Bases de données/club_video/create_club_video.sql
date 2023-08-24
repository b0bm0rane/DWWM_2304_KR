DROP DATABASE if EXISTS db_club_video;
CREATE DATABASE db_club_video;

USE db_club_video;

CREATE TABLE points_de_vente (
	point_de_vente_id INT, 
	numero_de_rue INT, 
	nom_de_rue VARCHAR(50), 
	ville VARCHAR(50), 
	PRIMARY KEY(point_de_vente_id)
);

CREATE TABLE cassettes (
	numero_de_cassette INT, 
	etat VARCHAR(50),
	date_de_mise_en_service DATE, 
	fk_film_id INT,
	PRIMARY KEY(numero_de_cassette)
);

CREATE TABLE clients (
	client_id INT, 
	nom_du_client VARCHAR(50), 
	prenom_du_client VARCHAR(50), 
	numero_de_rue INT, 
	nom_de_rue VARCHAR(50), 
	ville VARCHAR(50), 
	caution_du_client INT, 
	PRIMARY KEY(client_id)
);
	
CREATE TABLE films (
	film_id INT, 
	nom_du_film VARCHAR(50), 
	duree_du_film TIME, 
	PRIMARY KEY(film_id)
);
	
CREATE TABLE acteurs (
	acteur_id INT, 
	nom_acteur VARCHAR(50), 
	PRIMARY KEY(acteur_id)
);
	
CREATE TABLE louer (
	date_emprunt DATE, 
	date_restitution DATE, 
	fk_numero_de_cassette INT, 
	fk_client_id INT,
	PRIMARY KEY(fk_numero_de_cassette, fk_client_id)
);
	
CREATE TABLE genres (
	genre_id INT, 
	nom_genre VARCHAR(50), 
	type_de_public VARCHAR(50), 
	PRIMARY KEY(genre_id)
);
	
CREATE TABLE realisateurs (
	realisateur_id INT, 
	nom_du_realisateur VARCHAR(50), 
	PRIMARY KEY(realisateur_id)
);
	
CREATE TABLE proposer (
	fk_numero_de_cassette INT, 
	fk_point_de_vente_id INT, 
	PRIMARY KEY(fk_numero_de_cassette, fk_point_de_vente_id)
);

CREATE TABLE jouer (
	fk_film_id INT, 
	fk_acteur_id INT, 
	PRIMARY KEY(fk_film_id, fk_acteur_id)
);

CREATE TABLE classer (
	fk_film_id INT, 
	fk_genre_id INT, 
	PRIMARY KEY(fk_film_id, fk_genre_id)
);

CREATE TABLE realiser (
	fk_film_id INT, 
	fk_realisateur_id INT, 
	PRIMARY KEY(fk_film_id, fk_realisateur_id)
);

ALTER TABLE proposer 
	ADD CONSTRAINT fk_proposer_cassette FOREIGN KEY(fk_numero_de_cassette) REFERENCES cassettes(numero_de_cassette), 
	ADD CONSTRAINT fk_proposer_points_de_vente FOREIGN KEY(fk_point_de_vente_id) REFERENCES points_de_vente(point_de_vente_id);
	
ALTER TABLE jouer
	ADD CONSTRAINT fk_jouer_films FOREIGN KEY(fk_film_id) REFERENCES films(film_id), 
	ADD CONSTRAINT fk_jouer_acteurs FOREIGN KEY(fk_acteur_id) REFERENCES acteurs(acteur_id);
	
ALTER TABLE realiser 
	ADD CONSTRAINT fk_realiser_films FOREIGN KEY(fk_film_id) REFERENCES films(film_id), 
	ADD CONSTRAINT fk_realiser_realisateurs FOREIGN KEY(fk_realisateur_id) REFERENCES realisateurs(realisateur_id);
	
ALTER TABLE louer
	ADD CONSTRAINT fk_louer_cassettes FOREIGN KEY(fk_numero_de_cassette) REFERENCES cassettes(numero_de_cassette), 
	ADD CONSTRAINT fk_louer_clients FOREIGN KEY (fk_client_id) REFERENCES clients(client_id);
	
ALTER TABLE cassettes
	ADD CONSTRAINT fk_cassettes_films FOREIGN KEY(fk_film_id) REFERENCES films(film_id);