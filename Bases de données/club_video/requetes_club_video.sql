USE db_club_video;

SELECT * FROM films;

SELECT film_id, nom_du_film FROM films
WHERE film_id = 1;

SELECT nom_du_film
FROM films JOIN jouer ON films.film_id = jouer.fk_film_id 
JOIN acteurs ON jouer.fk_acteur_id = acteurs.acteur_id
WHERE nom_acteur = 'siffredi';

SELECT nom_du_film 
FROM films JOIN cassettes ON films.film_id = cassettes.fk_film_id 
JOIN louer ON cassettes.numero_de_cassette = louer.fk_numero_de_cassette 
JOIN clients ON louer.fk_client_id = clients.client_id 
WHERE clients.nom_du_client = 'dupont';