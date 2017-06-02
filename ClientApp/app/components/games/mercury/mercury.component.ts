import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'mercury',
    templateUrl: './mercury.component.html',
})


export class mercuryComponent {
    // one through ten


    one: Number =Math.floor((Math.random() * 10) + 1);
    two: Number = Math.floor((Math.random() * 10) + 1);


    ngAfterViewInit() {
            }
    


}
