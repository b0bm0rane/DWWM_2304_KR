USE db_ecf;

CREATE TABLE associer (
fk_id_rea INT NOT NULL, 
fk_id_img INT NOT NULL
);

USE db_ecf;

ALTER TABLE associer
ADD CONSTRAINT fk_associer_realisations FOREIGN KEY(fk_id_rea) REFERENCES realisations(id_rea), 
ADD CONSTRAINT fk_associer_images FOREIGN KEY(fk_id_img) REFERENCES images(id_img);