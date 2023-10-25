const apiUrl = "https://arfp.github.io/tp/web/html-css-js/03-zipcodes/zipcodes.json";
/*
// const { createApp } = Vue;

// async function afficherCodePostal(){
//     const reponse = await fetch(apiUrl);
//     const codePostal = await reponse.json();
//     console.log(codePostal);
// }

// createApp(afficherCodePostal).mount("#app");
*/
const list = document.getElementById("cpDataList")
var cp;
// var cpArray = [];

fetch(apiUrl)
.then((response)=> response.json())
.then((json) => {
cp = json;
ajoutCP();
/*
console.log(cp[0].nomCommune

// console.log(cpArray);
*/
});


function ajoutCP(){
    let html = '';
    for(let i = 0; i < cp.length; i++){
        html += `<option value="${cp[i].codePostal}">${cp[i].nomCommune}</option>`
/*        // cpArray.push(cp[i].codePostal);
        //ajoutOptionCP(cp[i].codePostal);
        // console.log(cp[i].codePostal)
*/
    };
    list.innerHTML = html;
};


console.log(list);
