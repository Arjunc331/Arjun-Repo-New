import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { LayoutComponent } from './layout/layout.component';
import { HomeComponent } from './home/home.component';
import { EmployeeComponent } from './employee/employee.component';
import { CustomerComponent } from './customer/customer.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'employee', component: EmployeeComponent },
  { path: 'customer', component: CustomerComponent }
];

@NgModule({
  declarations: [
    LayoutComponent,
    HomeComponent,
    EmployeeComponent,
    CustomerComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [LayoutComponent]
})
export class AppModule { }
