USE db_geo;

INSERT INTO pays
(pays_num, pays_nom, pays_superficie, pays_date_onu, pays_population, pays_capitale)
VALUES
(1, 'Allemagne', 356850, '1973-09-18', 83149300, 'Berlin'), 
(2, 'Australie', 7682300, '1945-11-01', 24000300, 'Canberra'), 
(3, 'Autriche', 83859, '1955-12-14', 8822267, 'Vienne'), 
(4, 'Brésil', 8511996, '1945-10-24', 211158000, 'Brasilia'), 
(5, 'Bulgarie', 110994, '1955-12-14', 7050034, 'Sofia');

INSERT INTO traverser
(num_fleuve, num_pays)
VALUES
(1, '4'), 
(1, '23'), 
(2, '9'), 
(3, '9'), 
(4, '9'), 
(4, '73'), 
(5, '9');

INSERT INTO fleuves
(fleuve_num, fleuve_nom)
VALUES
(1, 'Amazone'), 
(2, 'Loire'), 
(3, 'Seine'), 
(4, 'Garonne'), 
(5, 'Rhône'), 
(6, 'Rhin'), 
(7, 'Danube');

INSERT INTO continents
(continent_num, continent_nom)
VALUES
(1, 'Afrique'), 
(2, 'Amérique'), 
(3, 'Asie'), 
(4, 'Europe'), 
(5, 'Océanie');