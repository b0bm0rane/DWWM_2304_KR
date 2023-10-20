const apiUrl = "https://arfp.github.io/tp/web/html-css-js/02-cardgame/cardgame.json";
const { createApp } = Vue;
const app = {
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

}

createApp(app).mount("#app");