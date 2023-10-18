const app = {

    data() {

        return { // ATTRIBUTS

            litres: 0,
            prixLitre: 0
        
        }
    
    },

    computed: { // ATTRIBUTS CALCULES

        prixAPayer() {

            return this.litres * this.prixLitre;
        
        }
    
    },

    methods: { // METHODES

        ajoutLitre(){

            this.litres++;

        }, 

        ajoutPrix(){

            this.prixLitre++;
        }
    
    }

}

Vue.createApp(app).mount('#app');