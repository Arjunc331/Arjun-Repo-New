import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {

  title = "Business Developement";

  success_msg = true;

  optionValue: number | undefined;

  public selectTab(val: number) {
    this.optionValue = val;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
