class Participant
{
    constructor (_participantFromJson) {
        this.pays = _participantFromJson.pays;
        this.nomF = "";
        this.prenom = "";
        this.temps = _participantFromJson.temps;
        this.setNomComplet(_participantFromJson.nom);
    }

    setNomComplet(_NomComplet){
        let monNomComplet = _NomComplet.split(" ");
        this.nomF = monNomComplet[0];
        this.prenom = monNomComplet[1];
    }

}

export { Participant }
