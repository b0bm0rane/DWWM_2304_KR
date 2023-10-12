const inputDateNaissance = document.getElementById("dateNaissance");
const btnCalculer = document.getElementById("boutonCalculer");
const divResultat = document.getElementById("resultatCalculer")

/**
 * Vérifie si la date est passée
 * @param {Date} _date date à vérifier
 * @returns (boolean) vrai si la date est passée, sinon faux
 */
 function estPassée(_date){
    if (!(_date instanceof Date)){
        throw new Error("La date n'est pas valide");
    }

    dateAuj = new Date();

    return dateAuj > _date;
}

let maDate = new Date("2023-09-01");
console.log(estPassée(maDate));
