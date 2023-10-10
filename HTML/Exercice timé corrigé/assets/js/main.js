//VARIABLES

const prenom = document.getElementById("prenom");
const age = document.getElementById("age");
const ageRetraite = 64;
const reponse = document.getElementById("reponse");
const btnValider = document.getElementById("valider");
let txtRep = "";

var logTxt = "";

//FONCTIONS

function prenomValide(){
    return(prenom.value != "")
}

function ageValide(){
    return(age.value > 0);
}

function estMajeur(){
    return(age.value >= 18);
}

function statutRetraite(){
    if(age.value < ageRetraite){
        logTxt = "Il vous reste " + (ageRetraite - age.value) + " année(s) avant la retraite.";
        return logTxt;
    }

    else if(age.value > ageRetraite){
        let logTxt = `Vous êtes à la retraite depuis ${age.value - ageRetraite} année(s).`;
        return logTxt;
    }

    else{
        return "Vous prenez votre retraite cette année !";
    }
}



//AFFICHAGE

/*
 console.log(prenomValide());

 console.log(ageValide());

 console.log(estMajeur());

 console.log(afficherReponse());
*/



 btnValider.addEventListener("click", () => {

    let repComplete = "";

    if(!prenomValide() || !ageValide()){
        let texte="Compléter/corriger le formulaire";
        reponse.innerHTML = texte
    }

    else{
        repComplete = `Bonjour ${prenom.value}, votre âge est : ${age.value}.`;
        reponse.innerHTML = repComplete;

        
        if(estMajeur()){
            repComplete += `<p>Vous êtes majeur.</p>`;

            reponse.innerHTML=`${repComplete}`;
        }
        
        else{
            repComplete +="<p>Vous êtes mineur.</p>";
            reponse.innerHTML=`${repComplete}`;
        }
        if(age.value < ageRetraite){
            let rest = ageRetraite - age.value;
            repComplete += `<p>Il vous reste ${rest} année(s) avant la retraite.</p>`;
            reponse.innerHTML=`${repComplete}`;
        }
        
        else if(age.value > ageRetraite){
            let dif = age.value - ageRetraite
            repComplete += `<p>Vous êtes à la retraite depuis ${dif} année(s).</p>`;
            reponse.innerHTML=`${repComplete}`;
        }
    
        else{
            repComplete += `<p>Vous prenez votre retraite cette année !</p>`;
            reponse.innerHTML=`${repComplete}`;
        }
    }

})