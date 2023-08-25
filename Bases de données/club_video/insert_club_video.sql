USE db_club_video;

INSERT INTO points_de_vente
	(point_de_vente_id, numero_de_rue, nom_de_rue, ville)
VALUES
	(1, 1, 'bd des nations', 'mulhouse'), 
	(2, 69, 'rue des cochons', 'paris'), 
	(3, 50, 'rue bidule', 'besancon');

USE db_club_video;

INSERT INTO cassettes
	(numero_de_cassette, etat, date_de_mise_en_service, fk_film_id)
VALUES
	(10, 'tres bon etat', '2023-01-01', 1), 
	(69, 'tres sale', '2023-02-10', 10), 
	(13, 'abimee', '2022-12-01', 7);
	
USE db_club_video;
	
INSERT INTO louer
	(date_emprunt, date_restitution, fk_numero_de_cassette, fk_client_id)
VALUES
	('2023-01-15', '2023-01-20', 10, 7), 
	('2023-02-13', '2023-02-15', 69, 15), 
	('2023-12-20', '2023-01-05',13 ,84);
	
USE db_club_video;
	
INSERT INTO clients
	(client_id, nom_du_client, prenom_du_client, numero_de_rue, nom_de_rue, ville, caution_du_client)
VALUES
	(7, 'dupond', 'jean', '15', 'rue truc muche', 'mulhouse', 5), 
	(15, 'machin', 'gustave', '17', 'rue de la republique', 'paris', 10), 
	(84, 'dupont', 'dupond', '55', 'bd eiffel', 'besançon', 20);
	
USE db_club_video;
	
INSERT INTO films
	(film_id, nom_du_film, duree_du_film)
VALUES
	(1, 'la soupe aux choux', '1:38:00'), 
	(10, 'telle est la voie', '2:00:00'), 
	(7, 'le pere noel est une ordure', '1:23:00');
	
USE db_club_video;
	
INSERT INTO acteurs
	(acteur_id, nom_acteur)
VALUES
	(7, 'de funes'), 
	(13, 'siffredi'), 
	(32, 'lhermitte');
	
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
	(99, 'siffredi'), 
	(150, 'poire');
	
USE db_club_video;

INSERT INTO proposer
	(fk_numero_de_cassette, fk_point_de_vente_id)
VALUES
	(10, 1), 
	(69, 2), 
	(13, 3);	
	
USE db_club_video;

INSERT INTO jouer
	(fk_film_id, fk_acteur_id)
VALUES
	(1,7), 
	(10, 13),
	(7, 32);
	
USE db_club_video;

INSERT INTO classer
	(fk_film_id, fk_genre_id)
VALUES
	(1, 1), 
	(10, 13), 
	(7, 1);
	
USE db_club_video;

INSERT INTO realiser
	(fk_film_id, fk_realisateur_id)
VALUES
	(1, 55), 
	(10, 99), 
	(7, 150);