import { Component, OnInit } from '@angular/core';
import { CustomerComponent } from '../customer/customer.component';
import { EmployeeComponent } from '../employee/employee.component';
import { HomeComponent } from '../home/home.component';

@Component({
  selector: 'app-root',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
