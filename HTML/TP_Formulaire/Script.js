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

    let signesParMois = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"];

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

    if (formok){

        pseudo = signe "+" (valNum(prenom) + valNum(nom));

        return pseudo;
    }

}

// TEST 
console.log(valNum("kevin"));




// TEST
console.log(calculerSigne(1));




console.log(formok());