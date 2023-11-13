class Db{

    static async fetchJson(_url){
        let response = await fetch(_url);
        let json = await response.json();
        return json;
    }

}

export { Db };
