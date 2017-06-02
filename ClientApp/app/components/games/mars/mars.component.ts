import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'mars',
    templateUrl: './mars.component.html',
})


export class marsComponent {
    //1-30
    one: Number = Math.floor((Math.random() * 10) + 1 + (Math.random() * 10) + 1 + (Math.random() * 10) + 1);
    two: Number = Math.floor((Math.random() * 10) + 1 + (Math.random() * 10) + 1 + (Math.random() * 10) + 1);


    ngAfterViewInit() {
            }
    


}
