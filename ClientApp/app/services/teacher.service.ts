import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import 'rxjs/add/operator/toPromise';
import { Teacher } from "../models/teacherModel";

@Injectable()
export class TeacherService {


    constructor(private http: Http) {
    }

    getAll(): Promise<Teacher[]> {
        return this.http.get('/api/contactsApi/')
            .toPromise()
            .then(response => response.json())
            .then(teacher => Array.from(teacher, t => new Teacher(t)))
            .catch(error => console.log(error));
    }

}