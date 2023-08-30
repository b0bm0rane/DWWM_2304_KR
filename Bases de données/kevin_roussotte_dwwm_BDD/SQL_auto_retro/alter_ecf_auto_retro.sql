USE db_ecf;

ALTER TABLE realisations 
	ADD CONSTRAINT pk_id_rea PRIMARY KEY(id_rea);

USE db_ecf;

ALTER TABLE realisations 
MODIFY id_rea INT(10) NOT NULL AUTO_INCREMENT;

USE db_ecf;

ALTER TABLE images 
	ADD CONSTRAINT pk_id_img PRIMARY KEY(id_img);

USE db_ecf;

ALTER TABLE images
MODIFY id_img INT NOT NULL AUTO_INCREMENT;