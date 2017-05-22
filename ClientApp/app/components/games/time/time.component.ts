import { Component, ViewChild} from '@angular/core';
import { Observable } from 'rxjs'

@Component({
    selector: 'time',
    templateUrl: './time.component.html',
})


export class TimeComponent {

    // taking out guess for now
    //guess: number = this.getRandom();
    clock = Observable
        .interval(1000)
        .map(() => new Date());

    public hourguess: number = Math.floor(Math.random() * (12 - 1) + 1);
    public minguess: number = Math.random() >= 0.5 ? 0 : 30;

    // implemented directly so not needed, but will be needed to initialize random minutes other than 0 and 30 for 2nd graders
    //getRandom() {
    //    const hr = Math.floor(Math.random() * (24 - 1) + 1);
    //    const randTime = Math.random() >= 0.5;
    //    const min = randTime ? 0 : 30;
    //    return new Date().setHours(hr, min, 0);
    //}

    context: CanvasRenderingContext2D;
    @ViewChild("myCanvas") myCanvas;

    ngAfterViewInit() {
       
        let canvas = this.myCanvas.nativeElement;
        this.context = canvas.getContext("2d");
        this.drawclock();
    }
    drawclock() {

        var now = new Date();
        //var canvas = document.getElementById("canvas");
        //var ctx = document.getElementById('canvas').getContext('2d');
        //let ctx: CanvasRenderingContext2D = this.myCanvas.nativeElement.getContext('2d');
        //this.ctx = element[0].getContext('2d');
        //this.ctx = this.canvas.getContext('2d');
        //var canvas = <HTMLCanvasElement> $('#myCanvas').find('canvas').get(0);
        //var ctx: CanvasRenderingContext2D = canvas.getContext("2d");

        alert('things');
        const c = this.context;

        c.save();
        c.clearRect(0, 0, 150, 150);
        c.translate(75, 75);
        c.scale(0.4, 0.4);
        c.rotate(-Math.PI / 2);
        c.strokeStyle = 'black';
        c.fillStyle = 'white';
        c.lineWidth = 8;
        c.lineCap = 'round';

        // Hour marks
        c.save();
        for (var i = 0; i < 12; i++) {
            c.beginPath();
            c.rotate(Math.PI / 6);
            c.moveTo(100, 0);
            c.lineTo(120, 0);
            c.stroke();
        }
        c.restore();

        // Minute marks
        c.save();
        c.lineWidth = 5;
        for (i = 0; i < 60; i++) {
            if (i % 5 != 0) {
                c.beginPath();
                c.moveTo(117, 0);
                c.lineTo(120, 0);
                c.stroke();
            }
            c.rotate(Math.PI / 30);
        }
        c.restore();

        var sec = 0;
        var min = this.minguess;
        var hr = this.hourguess;
        hr = hr >= 12 ? hr - 12 : hr;

        c.fillStyle = 'black';

        // write Hours
        c.save();
        c.rotate(hr * (Math.PI / 6) + (Math.PI / 360) * min + (Math.PI / 21600) * sec);
        c.lineWidth = 14;
        c.beginPath();
        c.moveTo(-20, 0);
        c.lineTo(80, 0);
        c.stroke();
        c.restore();

        // write Minutes
        c.save();
        c.rotate((Math.PI / 30) * min + (Math.PI / 1800) * sec);
        c.lineWidth = 10;
        c.beginPath();
        c.moveTo(-28, 0);
        c.lineTo(112, 0);
        c.stroke();
        c.restore();

        // Write seconds
        c.save();
        c.rotate(sec * Math.PI / 30);
        c.strokeStyle = '#D40000';
        c.fillStyle = '#D40000';
        c.lineWidth = 6;
        c.beginPath();
        c.moveTo(-30, 0);
        c.lineTo(83, 0);
        c.stroke();
        c.beginPath();
        c.arc(0, 0, 10, 0, Math.PI * 2, true);
        c.fill();
        c.beginPath();
        c.arc(95, 0, 10, 0, Math.PI * 2, true);
        c.stroke();
        c.fillStyle = 'rgba(0, 0, 0, 0)';
        c.arc(0, 0, 3, 0, Math.PI * 2, true);
        c.fill();
        c.restore();

        c.beginPath();
        c.lineWidth = 14;
        c.strokeStyle = '#325FA2';
        c.arc(0, 0, 142, 0, Math.PI * 2, true);
        c.stroke();

        c.restore();

        //window.requestAnimationFrame(clock);
    }


}
