import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import 'rxjs/add/operator/toPromise';
import { Score } from "../models/scoreModel";

@Injectable()
export class ScoreService {


    constructor(private http: Http) {
    }

    getAll(): Promise<Score[]> {
        return this.http.get('/api/contactsApi/')
            .toPromise()
            .then(response => response.json())
            .then(score => Array.from(score, s => new Score(s)))
            .catch(error => console.log(error));
    }

}