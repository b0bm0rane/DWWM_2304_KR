USE db_ecf;

ALTER TABLE realisations
ADD COLUMN fk_id_img INT NOT NULL, 
ADD CONSTRAINT fk_realisations_images FOREIGN KEY(fk_id_img) REFERENCES images(id_img);