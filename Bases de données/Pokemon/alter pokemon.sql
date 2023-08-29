USE db_pokemon;

ALTER TABLE pokemon 
	ADD CONSTRAINT fk_pokemon_dresseur FOREIGN KEY(fk_dresseur_id) REFERENCES dresseur(dresseur_id), 
	ADD CONSTRAINT fk_pokemon_espece FOREIGN KEY(fk_espece_id) REFERENCES espece(espece_id);
	
ALTER TABLE typer
	ADD CONSTRAINT fk_typer_espece FOREIGN KEY(fk_espece_id) REFERENCES espece(espece_id), 
	ADD CONSTRAINT fk_typer_type_pokemon FOREIGN KEY(fk_type_id) REFERENCES type_pokemon(type_id);
	
ALTER TABLE posseder
	ADD CONSTRAINT fk_posseder_dresseur FOREIGN KEY(fk_dresseur_id) REFERENCES dresseur(dresseur_id), 
	ADD CONSTRAINT fk_posseder_type_objet FOREIGN KEY(fk_objet_id) REFERENCES type_objet(objet_id);