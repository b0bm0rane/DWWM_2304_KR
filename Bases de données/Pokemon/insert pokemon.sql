USE db_pokemon;

INSERT INTO espece
(espece_id, espece_nom)
VALUES
(1, 'Bulbizarre'), 
(2, 'Herbizarre'), 
(3, 'Florizarre'), 
(4, 'Salamèche'), 
(5, 'Reptincel'), 
(6, 'Dracaufeu'), 
(7, 'Carapuce'), 
(8, 'Carabaffe'), 
(9, 'Tortank'), 
(25, 'Pikachu');

USE db_pokemon;

INSERT INTO type_pokemon
(type_id, type_nom)
VALUES
(1, 'Acier'), 
(2, 'Combat'), 
(3, 'Dragon'), 
(4, 'Eau'), 
(5, 'Électrik'), 
(6, 'Fée'), 
(7, 'Feu'), 
(8, 'Glace'), 
(9, 'Insecte'), 
(10, 'Normal'), 
(11, 'Plante'), 
(12, 'Poison'), 
(13, 'Psy'), 
(14, 'Roche'), 
(15, 'Sol'), 
(16, 'Spectre'), 
(17, 'Ténèbres'), 
(18, 'Vol');

USE db_pokemon;

INSERT INTO pokemon
(pokemon_id, pokemon_niveau, pokemon_pv, pokemon_xp, pokemon_position_equipe, pokemon_date_capture, fk_dresseur_id, fk_espece_id)
VALUES
(20, 50, 100, 3000, 1, '2023-01-10', 1, 1);

USE db_pokemon;

INSERT INTO dresseur
(dresseur_id, dresseur_nom)
VALUES
(1, 'Sacha'), 
(2, 'Kévin'), 
(3, 'Florian'), 
(4, 'Natana'),
(5, 'Guillaume');

USE db_pokemon;

INSERT INTO type_objet
(objet_id, objet_nom)
VALUES
(1, 'Poké-Ball'), 
(2, 'Super-Ball'), 
(3, 'Potion'), 
(4, 'Rappel'), 
(5, 'Repousse');

USE db_pokemon;

INSERT INTO typer
(fk_espece_id, fk_type_id)
VALUES
(1, 11), 
(2, 11), 
(3, 11), 
(4, 7), 
(5, 7), 
(6, 7), 
(7, 4), 
(8, 4), 
(9, 4), 
(25, 5);

USE db_pokemon;

INSERT INTO posseder
(fk_dresseur_id, fk_objet_id, quantite)
VALUES
(1, 1, 10), 
(1, 2, 5), 
(1, 3, 3), 
(2, 2, 22), 
(2, 3, 12), 
(2, 4, 4), 
(3, 5, 2), 
(3, 2, 24), 
(3, 1, 0), 
(4, 2, 0),
(4, 1, 60), 
(4, 3, 5), 
(5, 4, 12), 
(5, 5, 17), 
(5, 1, 1);