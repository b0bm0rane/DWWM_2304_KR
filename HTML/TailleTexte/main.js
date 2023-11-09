var taillePolice = document.querySelector("#taille");
var tailleLorem = document.querySelector("#texte");

// si > 48 alors 16
function augmenter(){
    taillePolice.innerHTML++;
    if(taillePolice.innerHTML > 48){
        taillePolice.innerHTML = 16;
    }
    tailleLorem.style.fontSize = taillePolice.innerHTML + 'px';
}

// si < 8 alors 16
function diminuer(){
    taillePolice.innerHTML--;
    if(taillePolice.innerHTML < 8){
        taillePolice.innerHTML = 16;
    }
    tailleLorem.style.fontSize = taillePolice.innerHTML + 'px';
}

function validerPolice(){
}

document.getElementById("plus").addEventListener("click", augmenter);

document.getElementById("moins").addEventListener("click", diminuer);