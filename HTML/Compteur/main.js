var nombre = document.querySelector("#nbClick");

function compter(){
    nombre.innerHTML++;
}
document.getElementById("bouton").addEventListener("click", compter);