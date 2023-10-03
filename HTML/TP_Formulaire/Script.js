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
        && jours.value != "Choisissez votre jour"
        && mois.value != "Choisissez votre mois"
        && annees.value != "Choisissez votre année"
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
console.log(valNum("kevin"));



// TEST 
console.log(calculerSigne(1));



// TEST 
console.log(formok());



// TEST 
console.log(calculerPseudo());

// TEST

console.log(getCookie("pseudo"));

console.log(document.cookie);

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