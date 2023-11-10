const prenom = document.getElementById("inputPrenom");
const age = document.getElementById("inputAge");
const valider = document.getElementById("btnValider");
const reponse = document.getElementById("reponse");
const majorite = 18;
const retraite = 64;



function prenomValide(){
    return (prenom.value != "");
}


function ageValide(){
    return(age.value > 0);
}


function estMajeur(){
    return(age.value >= 18);
}



valider.addEventListener("click", () => {

    if(prenomValide() && ageValide()){
         reponse.innerHTML = `Bonjour <span>${prenom.value}</span>, votre âge est : <span>${age.value}</span>.`;
        

         if(estMajeur()){
            reponse.innerHTML += `<p>Vous êtes <span>majeur</span>.</p>`;
        }
        else{
            reponse.innerHTML += `<p>Vous êtes <span>mineur</span>.</p>`;
        }


            if(age.value < retraite){
                let reste = retraite - age.value;
                reponse.innerHTML += `Il vous reste <span>${reste}</span> année(s) avant la retraite.`;
            }
            else if(age.value > retraite){
                let depuis = age.value - retraite;
                reponse.innerHTML += `Vous êtes à la retraite depuis <span>${depuis}</span> années.`;
            }
            else{
                reponse.innerHTML += "Vous prenez votre retraite cette année !";
            }
    }









    else{
        reponse.innerHTML = "Compléter/corriger le formulaire.";

    }

    

})
