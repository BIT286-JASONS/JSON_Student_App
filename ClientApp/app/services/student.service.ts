import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import 'rxjs/add/operator/toPromise';
import { Student } from "../models/studentModel";

@Injectable()
export class StudentService {


    constructor(private http: Http) {
    }

    getAll(): Promise<Student[]> {
        return this.http.get('/api/contactsApi/')
            .toPromise()
            .then(response => response.json())
            .then(student => Array.from(student, s => new Student(s)))
            .catch(error => console.log(error));
    }

}