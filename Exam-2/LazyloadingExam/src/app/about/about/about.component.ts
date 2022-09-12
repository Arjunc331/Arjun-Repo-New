import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {
  // ngStyle
  title = "SNAD Developers";
  colorVal = "green";
  bgColorVal = "#ddd";

  // ngClass
  name = "SNAD Developers";
  clsName = "one"
  clsName2 = "two"

  constructor() { }

  ngOnInit(): void {
  }

}
