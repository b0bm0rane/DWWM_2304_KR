function control(_champTest) {
    let control = false;
    let chaine = document.getElementById(_champTest).value;
    if (!isNaN(chaine) && chaine >= 0) {
        control = true;

    } else {
        console.log(chaine + ' : n\'est pas valide');
        document.getElementById(_champTest).value = "0";
        document.getElementById(_champTest).focus();
    }

    return control;
}





function calcul(_champTest) {
    let resultat = control(_champTest);

    if (resultat == true) {

        document.querySelector("#prixtot1").value = Number(document.getElementById("qt1").value) * Number(document.querySelector("#pu1").value);
        document.querySelector("#prixtot2").value = Number(document.getElementById("qt2").value) * Number(document.querySelector("#pu2").value);

        document.querySelector("#total").value = Number(document.querySelector("#prixtot1").value) + Number(document.querySelector("#prixtot2").value);
    }


}

document.querySelector("#pu1").addEventListener("blur", function () {
    calcul("pu1");
});

document.querySelector("#pu2").addEventListener("blur", function () {
    calcul("pu2");
});

document.querySelector("#qt1").addEventListener("blur", function () {
    calcul("qt1");
});
document.querySelector("#qt2").addEventListener("blur", function () {
    calcul("qt2");
});
