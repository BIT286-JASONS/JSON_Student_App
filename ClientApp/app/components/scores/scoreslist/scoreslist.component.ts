import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'list',
    templateUrl: './scoreslist.component.html'
})
export class ScoresListComponent {
    public scores: Score[];

    constructor(http: Http) {
        http.get('/api/Scores/Get').subscribe(result => {
            this.scores = result.json() as Score[];
        });
        console.log(this.scores);
    }
}

interface Score {
    scoresId: number;
    gameId: number;
    studentId: number;
    teacherId: number;
    attemptTime: string;
    numberQuestions: number;
    numberCorrect: number;
    difficulty: number
}