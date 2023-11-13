import { Carte } from "./Carte.js";
import { Db } from "./Db.js";

const apiurl = "./assets/json/jeu_de_cartes.json"; // En local : /

const { createApp} = Vue;

const jeuDeCartesApp = {

    data() {
        return{
            cartes : []
        }
    },

    async mounted() {
        let json = await Db.fetchJson(apiurl);

        for(let item of json){
            let c = new Carte(item);
            this.cartes.push(c);
        }

        // this.cartes.sort((a, b) => a.attack - b.attack).reverse();
    },

    computed: {
        attackMax() {
           let attacks = this.cartes.map(c => parseInt(c.attack));
           let max = Math.max(...attacks)
           console.log("Tableau attaque : ",attacks)
           console.log(max)
           return this.cartes.find(carte => carte.attack == max);
        },

        armorMax() {
            let armors = this.cartes.map(c => parseInt(c.armor));
            let max = Math.max(...armors);
            console.log("Tableau armure : ",armors);
            console.log(max);
            return this.cartes.find(carte => carte.armor == max);
        },

        playedMax(){
            let played = this.cartes.map(c => parseInt(c.played));
            let max = Math.max(...played);
            console.log(played);
            console.log(max);
            return this.cartes.find (carte => carte.played == max);
        },

        victoryMax(){
            let victory = this.cartes.map(c => parseInt(c.victory));
            let max = Math.max(...victory);
            console.log(victory);
            console.log(max);
            return this.cartes.find(carte => carte.victory == max);
        }
    },

    methods: {

    }

}

Vue.createApp(jeuDeCartesApp).mount("#app");
