/* Football APP */ 

import { Db } from "./Db.js";
import { Equipe } from "./Equipe.js";

const apiurl = "./tournoi/football.json";

const { createApp } = Vue;

const appFootball = {
    data() {
        return {
            equipes: [],
            listeEquipes: []
        }
    },
    async mounted() {
        let json = await Db.fetchJson(apiurl);

        for(let item of json){
            let e = new Equipe(item);
            this.equipes.push(e);
        }

        this.listeEquipes = Array.from(new Set(this.equipes));

        console.log(this.listeEquipes);
 
    },
    computed: {

    },
    methods: {
        filtrerTeam1() {
            this.equipes = this.listeEquipes.filter(equipe => equipe.team1.toLowerCase().includes(this.search.toLowerCase().trim()));
        }

        // filtrerTeam2() {
        //     this.equipes = this.listeEquipes.filter(equipe => equipe.team2.toLowerCase().includes(this.search.toLowerCase().trim()));
        // }

    }
}

Vue.createApp(appFootball).mount("#appFootball");
