import { Component } from '@angular/core';

@Component({
    selector: 'alienroundup',
    templateUrl: './alienroundup.component.html',
    styleUrls: ['./alienroundup.component.css']
})
export class AlienRoundupComponent {
    guess = this.getNumber();
    items = this.createArray(this.guess);

    
    public alien: string = 'http://i.imgur.com/WH1UeVf.png';

    getNumber() {
        return Math.floor(Math.random() * (20 - 1) + 1);
    }
    createArray(num: number) {
        return new Array<number>(num);
    }
    submitForm(form: any): void {
        console.log('Form Data: ');
        console.log(form);
    }
}
