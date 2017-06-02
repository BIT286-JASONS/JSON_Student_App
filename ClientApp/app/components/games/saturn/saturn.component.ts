import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'saturn',
    templateUrl: './saturn.component.html',
})


export class saturnComponent {
    
    one: Number = Math.floor((Math.random() * 10) + 1);
    two: Number = Math.floor((Math.random() * 10) + 1);


    ngAfterViewInit() {
            }
    


}
