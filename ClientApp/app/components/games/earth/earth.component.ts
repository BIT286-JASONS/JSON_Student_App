import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'earth',
    templateUrl: './earth.component.html',
})


export class earthComponent {
    //// 1 - 20
    one: Number = Math.floor((Math.random() * 10) + 1 + (Math.random() * 10) + 1);
    two: Number = Math.floor((Math.random() * 10) + 1 + (Math.random() * 10) + 1);


    ngAfterViewInit() {
            }
    


}
