USE db_club_video;

INSERT INTO points_de_vente
	(point_de_vente_id, numero_de_rue, nom_de_rue, ville)
VALUES
	(1, 7, 'bd des nations', 'mulhouse'), 
	(2, 69, 'rue des cochons', 'paris');

USE db_club_video;

INSERT INTO cassettes
	(numero_de_cassette, etat, date_de_mise_en_service, fk_film_id)
VALUES
	(10, 'tres bon etat', '2023-01-01', 1), 
	(69, 'tres sale', '2023-02-10', 10);
	
USE db_club_video;
	
INSERT INTO louer
	(date_emprunt, date_restitution, fk_numero_de_cassette, fk_client_id)
VALUES
	('2023-01-15', '2023-01-20', 10, 7), 
	('2023-02-13', '2023-02-15', 69, 15);
	
USE db_club_video;
	
INSERT INTO clients
	(client_id, nom_du_client, prenom_du_client, numero_de_rue, nom_de_rue, ville, caution_du_client)
VALUES
	(7, 'dupond', 'jean', '15', 'rue truc muche', 'mulhouse', 5), 
	(15, 'machin', 'gustave', '17', 'rue de la republique', 'paris', 10);
	
USE db_club_video;
	
INSERT INTO films
	(film_id, nom_du_film, duree_du_film)
VALUES
	(1, 'la soupe aux choux', '1:38:00'), 
	(10, 'telle est la voie', '2:00:00');
	
USE db_club_video;
	
INSERT INTO acteurs
	(acteur_id, nom_acteur)
VALUES
	(7, 'de funes'), 
	(13, 'siffredi');
	
USE db_club_video;
	
INSERT INTO genres
	(genre_id, nom_genre, type_de_public)
VALUES
	(1, 'comedie', 'tout public'), 
	(13, 'porno', 'public majeur');
	
USE db_club_video;
	
INSERT INTO realisateurs
	(realisateur_id, nom_du_realisateur)
VALUES
	(55, 'girault'), 
	(99, 'siffredi');