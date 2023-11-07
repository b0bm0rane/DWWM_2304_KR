class Student 
{
    constructor(_studentFromJson) {
        this.lastName = '';
        this.firstName = '';
        this.setGrade(_studentFromJson.grade)
        this.setFullName(_studentFromJson.fullname);
    }

    setGrade(_grade) {
        if(_grade < 0 || _grade > 20) {
            throw new Error("La note doit être comprise entre 0 et 20");
        }
        this.grade = _grade;
    }

    setFullName(_fullName) {
        // _fullname = "Armanetti"
        let myFullName = _fullName.split(" ");

        if(myFullName.length < 2) {
            throw new Error("Nom ou prénom invalide(s)")
        }

        // myFullName = ["Armanetti", "Michaël"]

        if(myFullName[0].length < 2) {
            throw new Error("Le nom est invalide")
        }
        this.lastName = myFullName[0];

        if(myFullName[1].length < 2) {
            throw new Error("Le prénom est invalide")
        }

        this.firstName = myFullName[1];
    }

    /*
    succeded(_minGrade) {
        return this.grade >= _minGrade;
    }*/
}

export { Student }