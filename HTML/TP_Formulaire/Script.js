// FONCTIONS

function valNum(_chaine) {

    let chaineMajuscule = _chaine.toUpperCase();

    let somme = 0;

    for(let i = 0; i < chaineMajuscule.length; i++) {

        somme += chaineMajuscule.charCodeAt(i) - 64;

    }

    return somme;

}


function calculerSigne(_mois) {

    let signe = "";

    let signesParMois = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagitaire"];

    signe = signesParMois[_mois - 1];

    return signe;

}

function formok(){

    let nom = document.getElementById("nom");
    
    let prenom = document.getElementById("prenom");
    
    let mail = document.getElementById("mail");

    let jours = document.getElementById("jours");

    let mois = document.getElementById("mois");

    let annees = document.getElementById("annees");

    if(
        nom.value != ""
        && prenom.value != ""
        && mail.value != ""
        && jours.value != "0"
        && mois.value != "0"
        && annees.value != "0"
    ) {

        return true;

    }

    return false;
}

function calculerPseudo() {

    let pseudo = document.getElementById("pseudo");

    let boutonValider = document.getElementById("validation");

    if (formok() == true){

        let mois = document.getElementById("mois").value;
        let nom = document.getElementById("nom").value;
        let prenom = document.getElementById("prenom").value;

        let valeurPseudo = calculerSigne(mois) + (valNum(nom) + valNum(prenom));

        pseudo.value = valeurPseudo;

        boutonValider.disabled = false;

    }
    else {

        boutonValider.disabled = true;

    }

}

function valider(){

    let tableauInputs = document.querySelectorAll(".donnees");

    for(let i = 0; i < tableauInputs.length; i++) {

        document.cookie = tableauInputs[i].id + "=" + tableauInputs[i].value;

    }

    document.cookie = "nbJoursAnniv=" + nbJoursAnniv() + ";"; 

    console.log("C'est ok !");

}

function redirection(){

    document.location.href="Accueil.html"

}

function getCookie(_cle){

    let valeur = "";

    let tabCookies = document.cookie.split("; ");
    tabCookies.forEach(element => {

        let tabValeur = element.split("=");
        if(tabValeur[0] == _cle) {

            valeur = tabValeur[1];

        }

    })

    return valeur;

}

function nbJoursAnniv(){

    let jourAnniv = document.getElementById("jours").value;
    let moisAnniv = document.getElementById("mois").value - 1;
    let anneeAnniv = document.getElementById("annees").value;

    let dateAnniv = new Date(anneeAnniv, moisAnniv, jourAnniv);

    let dateAuj = new Date();
    
if

    let dureeMs = dateAuj - dateAnniv;
    console.log(dureeMs);

    let dureeEnJour = Math.floor(dureeMs / (1000 * 60 * 60 * 24));
    console.log(dureeEnJour);


    return dureeEnJour;

}

// AJOUT D'ECOUTEURS

let inputs = []; /* = let */
inputs = document.querySelectorAll("input");
inputs.forEach(element => element.addEventListener("input", calculerPseudo));

let selects = [];
selects = document.querySelectorAll("select");
selects.forEach(selection => selection.addEventListener("change", calculerPseudo));

let validation = document.getElementById("validation");
validation.addEventListener("click", valider);

/*

(function (x) { return 2 * x });
x => 2 * x;

function double(x) {
    return 2 * x;
}

double

------------------------------------------------------------------------------------------------------------------------------------------------------

function recupererCookie(_cle) {

    let valeur = "";

    let tabCookies = document.cookie.split("; ");
    for(let i = 0; i < tabCookies.length; i++) {

        let tabValeur = tabCookies[i].split("=");
        if(tabValeur[0] == _cle) {

            valeur = tabValeur[1];

        }

    }

    return valeur;

}

------------------------------------------------------------------------------------------------------------------------------------------------------

function getCookie(_cle) {
    
    let valeur = "";

    let tabCookies = document.cookie.split("; ");
    for(let i = 0; i < tabCookies.length; i++) {

        let tabValeur = tabCookies[i].split("=");
        if(tabValeur[0] == _cle) {

            valeur = tabValeur[1];

        }

    }

    return valeur;

}*/

// TEST 


/*

monTableau : ENTIER[]
i : ENTIER


POUR i ALLANT DE 0 à |monTableau| EXCLU
    // actions (l'élément est monTableau[i])
FIN POUR

POUR CHAQUE élément DANS monTableau
    // actions (l'élément est élément)
FIN POUR CHAQUE

------------------------------------------------------------------------------------------------------------------------------------------------------

function nbJoursAnniv(dateAnnivStr)
{
    var dateActuelle = new Date();
    var tabDateAnniv = dateAnnivStr.split('/');
    var jourAnniv = new Date(dateActuelle.getFullYear(), tabDateAnniv[1]-1,tabDateAnniv[0]);
    
    if (jourAnniv < dateActuelle)
    {   
        jourAnniv.setFullYear(dateActuelle.getFullYear()+1);
        var diff = jourAnniv-dateActuelle;
    }
    else
    {       
        var diff =  jourAnniv-dateActuelle;
    }
    var retour = Math.floor(diff / (1000*60*60*24));
    return retour;
}

*/

/* 

FRANCK 

function nbJoursAnniv(dateAnnivStr)
{
    var dateActuelle = new Date();
    var tabDateAnniv = dateAnnivStr.split('/');
    var jourAnniv = new Date(dateActuelle.getFullYear(), tabDateAnniv[1]-1,tabDateAnniv[0]);
    
    if (jourAnniv < dateActuelle)
    {   
        jourAnniv.setFullYear(dateActuelle.getFullYear()+1);
        var diff = jourAnniv-dateActuelle;
    }
    else
    {       
        var diff =  jourAnniv-dateActuelle;
    }
    var retour = Math.floor(diff / (1000*60*60*24));
    return retour;
}

SAÏD 

function ecrireAccueil(){

    if(getCookie('nom') != null){

        document.querySelector('#cell_nom').textContent = getCookie('nom')

        document.querySelector('#cell_prenom').textContent = getCookie('prenom')

        document.querySelector('#cell_dateNaissance').textContent = getCookie('date_naissance')

        document.querySelector('#cell_pseudo').textContent = getCookie('pseudo')

        let chaineDate =  getCookie('date_naissance')

        document.querySelector("#cell_nbJours").textContent = nbJoursAnniv(chaineDate)

    }

   

}

ecrireAccueil();

------------------------------------------------------------------------------------------------------------------------------------------------------

SAÏD

function nbJoursAnniv(chaineDate) {

    let dateJour = new Date(); // récupérer la date du jour

    console.log("dateJour : " + dateJour)

    let annee =new Date()

    annee = dateJour.getFullYear();

    var dateAnni = new Date(chaineDate); // récupérer la date d'anni

    console.log("dateAnni : " + dateAnni);

    let diff = dateAnni.getTime() - dateJour.getTime();

    if (dateAnni.getFullYear() == dateJour.getFullYear()) {

        diff = Math.ceil(diff / (1000 * 3600 * 24));

    }

    else if(dateAnni.getFullYear() < dateJour.getFullYear()) {

        dateJour = new Date();

        let enCours = new Date()

        enCours = dateAnni.setFullYear(dateJour.getFullYear()+1);

        diff = dateAnni.getTime() - dateJour.getTime();

        diff = Math.ceil(diff / (1000 * 3600 * 24));

    }

    else{

            dateJour = new Date();

            let enCours = new Date()

            enCours = dateAnni.setFullYear(dateJour.getFullYear());

            diff = dateAnni.getTime() - dateJour.getTime();

            diff = Math.ceil(diff / (1000 * 3600 * 24));

    }

    return diff;

}

*/