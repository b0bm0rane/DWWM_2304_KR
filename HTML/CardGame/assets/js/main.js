import { Db } from "./Db.js";
import { Card } from "./Card.js";

const apiUrl = "https://arfp.github.io/tp/web/html-css-js/02-cardgame/cardgame.json";
const { createApp } = Vue;

const cardGameApp = {
    data() {
        return {
            cards: []
        }
    },

    async mounted() {
        let json = await Db.fetchJson(apiUrl); // await nécessaire car fonction asynchrone

        for(let item of json) {
            let c = new Card(item);
            this.cards.push(c);            
        }
/*
        json.forEach((item) => {
            let c = new Card(item);
            this.cards.push(c);     
        })

        for(let i = 0; i < json.length; i ++){
            let c = new Card(json[i]);
            this.cards.push(c);            
        }

*/

        console.log(this.cards);
    },

    computed: {},

    methods: {

    }
}

/*const app = {
    data() {
        return {
            codeInterval: null,
            message: "Bonjour !",
            valeurInput: "connard",
            appelleFlo: false
        }
    
    },

    methods: {

        clickBouton() {

            if(this.appelleFlo) {

                clearInterval(this.codeInterval);
                this.appelleFlo = false;
            }

            else {
                
                this.codeInterval = setInterval(() => {

                    this.message += "Connard !!! ";
                
                }, 1000);
                this.appelleFlo = true;
            }

        }

    }

}*/

/*const app = {
    data() { // données de l'application donc plus besoin de document.getElementByiD
        return {
            message: "Bonjour !",
            valeurInput: "toto"
        }
    },
    mounted() { // code initialisé quand la page s'affiche ex : json
        setInterval(() => {
            this.message += "a<br>";
        }, 1000);
    },
    methods : { // méthodes évènements donc plus besoin de addEventListener
        clickBouton() {
            
        }
    }
} 

createApp(app).mount("#app");*/

createApp(cardGameApp).mount("#app");
