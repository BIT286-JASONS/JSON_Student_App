import { Component } from '@angular/core';

@Component({
    selector: 'mathblaster',
    templateUrl: './mathblaster.component.html',
    styleUrls: ['./mathblaster.component.css']
})
export class MathBlasterComponent {
    guess = this.getNumber();
    items = this.createArray(this.guess);

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
