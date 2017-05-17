import { Component } from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'time',
    templateUrl: './time.component.html',
})


export class TimeComponent {

    guess: number = this.getRandom();
    clock = Observable
        .interval(1000)
        .map(() => new Date());


    getRandom() {
        const randHour = Math.floor(Math.random() * (24 - 1) + 1);
        const randTime = Math.random() >= 0.5;
        const minutes = randTime ? 0 : 30;
        return new Date().setHours(randHour, minutes, 0);
    }

}
