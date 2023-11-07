/* App 10000 mètres */

// Gagnant : indice 0 du tableau

import { Participant } from "./Participant.js"

const app = {
        
    data() {
        return {
            participants: [],
        }
    }, 

    async mounted() {
        let response = await fetch("./data/resultats.json");
        this.participants = await response.json();

        console.log(this.participants);

        for(let i = 0; i < this.participants.length; i++) {
            this.participants[i] = new Participant (this.participants[i]);
        }
        
        this.participants.sort((a, b) => a.temps - b.temps);
    },

    computed: {
        nbParticipants(){
            return this.participants.length;
        },

        gagner(){
            
        }

    },

    methods: {

    }
}

Vue.createApp(app).mount("#app");
