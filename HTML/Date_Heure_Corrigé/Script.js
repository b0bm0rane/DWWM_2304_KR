function afficher() 
{
    var dateJour= new Date() ;
    let annee =dateJour.getFullYear();
    let jour=dateJour.getDate();
    let mois=dateJour.getMonth()+1;
    mois=(mois<10) ?'0'+mois :mois;
    jour=(jour<10)?'0'+jour:jour;
    let chaineDate= jour+'-'+ mois +'-'+ annee;
    console.log('verification de la date:'+chaineDate);
    document.getElementById("madate").value=chaineDate;
    
} 

document.querySelector("#btndate").addEventListener("click", function(){ 
afficher();

})

function afficherHeure() {
    dateJour = new Date();

    let heure = dateJour.getHours();
    let minute = dateJour.getMinutes();
    let seconde = dateJour.getSeconds();
    if (heure < 10 && heure > 0) {
        heure = '0' + heure;
    }

    if (minute < 10 && minute>0) {
        minute = '0' + minute;
    }
    let chaineSeconde=((seconde<10)? "0" :"" )+ seconde;
    var chaineHeure= heure + ':'+ minute+ ':' + chaineSeconde;
    document.querySelector("#monheure").value=chaineHeure;
    setInterval(afficherHeure,1000);
}

let btnHeure= document.querySelector("#btnheure");

btnHeure.addEventListener("click", afficherHeure);


let txtheure= document.querySelector("#monheure");
txtheure.value='text';

txtheure.value='text2';
document.getElementById('madate').value='une date';

let montab=[];
montab=document.querySelectorAll(".btn");
montab[0].value="mon bouton date";


