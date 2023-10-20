const apiUrl = "https://arfp.github.io/tp/web/vuejs/10-cereals/cereals.json";
const { createApp } = Vue;
const app = {
    data() {
        return {
            message: "Bonjour !"
        }
    }
}

createApp(app).mount("#app");