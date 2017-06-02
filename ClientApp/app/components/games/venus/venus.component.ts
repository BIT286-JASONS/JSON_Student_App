import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'venus',
    templateUrl: './venus.component.html',
})


export class venusComponent {
    //1 - 15
    one: Number = Math.floor((Math.random() * 10) + 1 + ((Math.random() * 10) + 1 / 2));
    two: Number = Math.floor((Math.random() * 10) + 1 + ((Math.random() * 10) + 1 / 2));


    ngAfterViewInit() {
            }
    


}
