function getCookie(_cle){

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


// TESTS

console.log(getCookie("pseudo"));