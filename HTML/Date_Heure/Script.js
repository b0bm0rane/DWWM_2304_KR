function afficher(){
    let dateJour= new Date();
    let annee= dateJour.getFullYear();
    let jour= dateJour.getDate();
    let mois= dateJour.getMonth()+1;
    mois= (mois<10) ? "0" + mois : mois;
    jour= (jour<10) ? "0" + jour : jour;
    let chaineDate = jour + "-" + mois + "-" + annee;
    document.getElementById("maDate").value=chaineDate;
}

document.querySelector("#btndate").addEventListener("click", function(){
    afficher();
})