import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'time',
    templateUrl: './time.component.html',
})


export class flashcardsComponent {
    
    one: Number =Math.floor((Math.random() * 10) + 1);
    two: Number = Math.floor((Math.random() * 10) + 1);


    ngAfterViewInit() {
            }
    


}
