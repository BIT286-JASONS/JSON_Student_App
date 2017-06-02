import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'list',
    templateUrl: './scoreslist.component.html'
})
export class ScoresListComponent {
    public scores: Score[];

    constructor(http: Http) {
        http.get('/api/Score/Get').subscribe(result => {
            this.scores = result.json() as Score[];
        });
        console.log(this.scores);
    }
}

//create(name: string): Observable < Hero > {
//    let headers = new Headers({ 'Content-Type': 'application/json' });
//    let options = new RequestOptions({ headers: headers });

//    return this.http.post(this.heroesUrl, { name }, options)
//        .map(this.extractData)
//        .catch(this.handleError);
//}

interface Score {
    id: number;
    gameID: number;
    studentID: number;
    numberQuestions: number;
    numberCorrect: number;
    time: string;
    teacherID: number
}