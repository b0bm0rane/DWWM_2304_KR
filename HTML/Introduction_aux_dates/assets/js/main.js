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
    
    let dateAuj = new Date();

    return dateAuj > _date;
}

function diffDate(_dateDiff){
    if (!(_dateDiff instanceof Date)){
        throw new Error("La date n'est pas valide");
    }
    
    let dateAuj = new Date();

    let diffDates = dateAuj - _dateDiff;

    return parseInt(diffDates / 3600 / 60 / 60 / 24 / 365);
    
}

btnCalculer.addEventListener("click", () => {
    let dateNaissance = new Date(inputDateNaissance.value);

    if(estPassée(dateNaissance)){
        divResultat.innerHTML = `Vous êtes né le ${dateNaissance.toLocaleDateString("fr")} à ${dateNaissance.toLocaleTimeString("fr")}.`;
    }
    else{
        divResultat.innerHTML = "La date n'est pas passée";
    }
})