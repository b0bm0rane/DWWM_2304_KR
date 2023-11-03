import { Db } from "./Db.js";
import { Student } from "./Student.js";

const apiUrl = "./eval.json";
const { createApp } = Vue;

const classGradApp = {
    data() {
        return {
            students: []
        }
    },
    async mounted() {
        let json = await Db.fetchJson(apiUrl);

        for(let item of json) {
            let s = new Student(item);
            this.students.push(s);
        }
        console.log(this.students);
    },
    computed: {},

    methods: {}
}
createApp(classGradApp).mount("#app");
