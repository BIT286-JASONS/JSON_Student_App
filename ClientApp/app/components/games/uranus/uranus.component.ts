import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'uranus',
    templateUrl: './uranus.component.html',
})


export class uranusComponent {
    
    one: Number =Math.floor((Math.random() * 10) + 1);
    two: Number = Math.floor((Math.random() * 10) + 1);


    ngAfterViewInit() {
            }
    


}
