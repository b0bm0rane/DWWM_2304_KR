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

// TEST

console.log(calculerSigne(1));