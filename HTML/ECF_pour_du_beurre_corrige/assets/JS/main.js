import { Student } from './Student.js'

const app = {
    data() {
        return {
            students: [],
            minGrade: 12,
            studentName: '',
            studentGrade: 0
        }
    },
    async mounted() {
        let response = await fetch('ECF_pour_du_beurre_corrige\assets\JSON\eval.json');
        this.students = await response.json();

        for(let i = 0; i < this.students.length; i++) {
            this.students[i] = new Student(this.students[i]);
        }

        this.students.sort((a,b) => a.grade - b.grade).reverse();
    },    
    computed: {
        nbStudents() {
            return this.students.length;
        },
        avgGrade() {
            let sum = 0;
            for(let student of this.students) {
                sum += student.grade;
            }
            return (sum / this.nbStudents).toFixed(2)
        },
        nbStudentsAboveAvg() {
            let studentsWithGradeAboveAvg = this.students.filter(student => student.grade > this.avgGrade);
            return studentsWithGradeAboveAvg.length;
        }
    },
    methods: {
        addStudent() {
            let tmpStudent = {
                "fullname": this.studentName, 
                "grade": this.studentGrade
            }

            try {
                let newStudent = new Student(tmpStudent);
                this.students.push(newStudent);
                this.students.sort((a,b) => a.grade - b.grade).reverse();
            } catch(error) {
                alert(error.message);
            }            
        }
    }
}

Vue.createApp(app).mount("#app");


/*
try {
    let reponse = await fetch('./eval.json');
    let json = await reponse.json();
    console.log(json);
} catch(error) {
    alert(error);
}


fetch('./eval22.json')
.then(reponse => reponse.json())
.then(json => console.log(json))
.catch(error => alert("ERREUR: " + error));

*/