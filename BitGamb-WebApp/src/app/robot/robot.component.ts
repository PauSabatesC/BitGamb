import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-robot',
  templateUrl: './robot.component.html',
  styleUrls: ['./robot.component.css']
})
export class RobotComponent implements OnInit {

  robots: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getRobots();
  }

  getRobots() {

    this.http.get('http://localhost:5000/bitgamb/robots').subscribe(response => {
      this.robots = response;
    }, error => {
      console.log(error);
    });

  }


}
