class MaDate
{
    constructor(_date){
    this.dateAuj = new Date();
    this.dateNaissance = _date;
    }

    estPassée(){
        return this.dateAuj > this.dateNaissance;
    }

    calculerDiffDates(){
        let diffDates=dateAuj-dateNaissance;
        return parseInt(diffDates/1000/60/60/24);
    }
}

export {MaDate};
