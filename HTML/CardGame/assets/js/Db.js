class Db // classe de données fausse database juste pour le téléchargement
{
    static async fetchJson(_url) { // méthode static = rattachée à la classe
        let response = await fetch(_url);
        let json = await response.json();
        return json;
    }
}

// let result = await Db.fetchJson('http://....');

export { Db }
