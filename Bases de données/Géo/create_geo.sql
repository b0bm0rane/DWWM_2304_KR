DROP DATABASE if EXISTS db_geo;

CREATE DATABASE db_geo;

USE db_geo;

CREATE TABLE pays (
	pays_num INT NOT NULL, 
	pays_nom VARCHAR(50) NOT NULL UNIQUE, 
	pays_superficie INT NOT NULL, 
	pays_date_onu DATE NOT NULL, 
	pays_population INT NOT NULL, 
	pays_capitale VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE traverser (
	fk_pays_num INT NOT NULL, 
	fk_fleuve_num INT NOT NULL
);

CREATE TABLE fleuves (
	fleuve_num INT NOT NULL, 
	fleuve_nom VARCHAR(50) NOT NULL
);

CREATE TABLE continents (
	continent_num INT NOT NULL, 
	continent_nom VARCHAR(50) NOT NULL
);