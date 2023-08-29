-- USE db_pokemon;
-- 
-- -- CREATE VIEW liste_espece AS
-- -- SELECT e.espece_id,e.espece_nom
-- -- FROM espece AS e;
-- -- 
-- -- SELECT dresseur_nom, espece_nom, type_nom, pokemon_xp FROM pokemon 
-- -- JOIN dresseur ON dresseur.dresseur_id = pokemon.fk_dresseur_id 
-- -- JOIN espece ON espece.espece_id = pokemon.fk_espece_id
-- -- JOIN typer ON typer.fk_espece_id = pokemon.fk_espece_id
-- -- JOIN type_pokemon ON type_pokemon.type_id = typer.fk_type_id
-- -- ORDER BY pokemon_xp DESC;

USE db_pokemon;

-- Donner les noms des pokémons de Kévin

SELECT espece_nom FROM pokemon
JOIN dresseur ON dresseur.dresseur_id = pokemon.fk_dresseur_id
JOIN espece ON espece.espece_id = pokemon.fk_espece_id
WHERE dresseur.dresseur_nom = 'Kévin';

-- Donner les noms d'espèces de type "Plante"

SELECT espece_nom FROM typer
JOIN espece ON espece.espece_id = typer.fk_espece_id
JOIN type_pokemon ON type_pokemon.type_id = typer.fk_type_id
WHERE type_pokemon.type_nom = 'Plante';

-- Donner les noms de pokémon dans l'équipe de Sacha

SELECT espece_nom FROM pokemon
JOIN espece ON espece.espece_id = pokemon.fk_espece_id
JOIN dresseur ON dresseur.dresseur_id = pokemon.fk_dresseur_id
WHERE dresseur.dresseur_nom = 'Sacha';

-- Donner les noms de pokémon dans le PC de Sacha

SELECT espece_nom FROM pokemon
JOIN espece ON espece.espece_id = pokemon.fk_espece_id
JOIN dresseur ON dresseur.dresseur_id = pokemon.fk_dresseur_id
WHERE (dresseur.dresseur_nom = 'Sacha') AND (pokemon.pokemon_position_equipe IS NULL);

-- Donner les noms de dresseurs qui possèdent 10 pokéballs ou plus et qui ont au moins un pokémon de type Feu

SELECT dresseur.dresseur_nom FROM dresseur
JOIN posseder ON dresseur.dresseur_id = posseder.fk_dresseur_id
JOIN type_objet ON type_objet.objet_id = posseder.fk_objet_id
JOIN pokemon ON dresseur.dresseur_id = pokemon.fk_dresseur_id
JOIN espece ON espece.espece_id = pokemon.fk_espece_id
JOIN typer ON espece.espece_id = typer.fk_espece_id
JOIN type_pokemon ON type_pokemon.type_id = typer.fk_type_id
WHERE (type_objet.objet_nom = 'Poké-Ball') AND  (posseder.quantite >= 10) AND (type_pokemon.type_nom = 'Feu');