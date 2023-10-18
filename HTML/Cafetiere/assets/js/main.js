const app = {

    data() {

        return {

            // ATTRIBUTS

            produit: "Cafetière",
            prixHT: 0,
            taxe: 20

        }

    },

    computed: {

        // ATTRIBUTS CALCULES

        prixTTC() {

            return this.prixHT + this.prixHT * this.taxe / 100;

        },

        prixArrondi() {

            return Math.round(this.prixTTC);

        }

    },

    methods: {

        // METHODES

        maFonction() {
            console.log("Bonjour !");
        }

    }

}

Vue.createApp(app).mount('#app');