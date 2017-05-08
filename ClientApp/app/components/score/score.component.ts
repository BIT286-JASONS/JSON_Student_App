import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'score',
    templateUrl: './score.component.html'
})
export class ScoreComponent {
    public scores: Score[];

    constructor(http: Http) {
        http.get('/api/Score/Get').subscribe(result => {
            this.scores = result.json() as Score[];
        });
    }
}

interface Score {
    id: number;
    gameID: number;
    studentID: number;
    numberQuestions: number;
    numberCorrect: number;
    time: string;
    teacherID: number
}