import { DB } from "./DB.js";
import { Cereale } from "./Cereale.js";

const apiurl = "./assets/json/cereals.json";

const { createApp } = Vue;

const cerealesApp = {

    data() {

        return {
            cereales: [],
            cerealesBrutes: [],
            asc: true
        }

    },

    async mounted() {
        let json = await DB.fetchJson(apiurl);
        
        this.cereales = json.data;
        // for(let item of this.cereales){
        //     this.cerealesBrutes.push(new Cereale(item));            
        // }
        // console.log(this.cerealesBrutes);

        this.cerealesBrutes = [...this.cereales]; // = this.cerealesBrutes = Array.from(this.cereales);

        console.log(this.cerealesBrutes)
    },

    computed: {

    },

    methods: {
        trier(event) {
            console.log(event.target);
            let attribut = event.target.id;
            console.log(attribut);
            this.cereales.sort((a, b) => {
                if(a[attribut] > b[attribut]){
                    return 1;
                }
                else if(a[attribut] < b[attribut]){
                    return -1;
                }
                else{
                    return 0;
                }
            })
            if(this.asc == false){
                this.cereales.reverse();
            }
            this.asc = !this.asc;
        }
    }

}

Vue.createApp(cerealesApp).mount("#app");