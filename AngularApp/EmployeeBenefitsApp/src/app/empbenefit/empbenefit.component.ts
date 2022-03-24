import { EmployeeService } from './../employeeservice.service';
import { Component, OnInit } from '@angular/core';
import { Dependent } from '../employee';
import { IEmployee } from '../employee';
import { BenefitSummary } from '../employee';
import { PayCheckBenefit } from '../employee';

@Component({
  selector: 'app-empbenefit',
  template: `
    <h2>All Employees - {{ employees.length }}</h2>
    <table>
      <tr><td>Employee: <input type="text" id="employee">
      Salary: <input type="text" id="salary"> <input type="button" value="Add Employee" (click)="addEmployee()"></td></tr>
    </table><br>
    <div>Dependent:<input type="text" id="dependent"></div><br>
    <table>
      <tr><td>Employee Name</td><td>Anual Pay</td><td>Dependents</td><td>Add Dependent</td><td>Remove Dependent</td><td>View Benefit</td></tr>
      <tr *ngFor="let emp of employees">
        <td>{{emp.name}}</td>
        <td>{{emp.annualPay}}</td>
        <td>
          <div *ngFor="let d of emp.dependents">
            <div *ngIf="d.type == 0"> Spouse: {{d.name}} </div>
            <div *ngIf="d.type == 1"> Child: {{d.name}} </div>
          </div></td>
        <td><input type="button" value="Add" (click)="addDependent(emp)"></td>
        <td><input type="button" value="Remove" (click)="removeDependent(emp)"></td>
        <td><input type="button" value="View" (click)="getBenefitsSummary(emp)"></td>
      </tr>
    </table>
    <div *ngIf="benefitSummary != undefined">
      <h1>Benefit Summary</h1>
      <table>
        <tr><td>AnnualBenefitCost:{{benefitSummary.annualBenefitCost}}</td></tr>
        <tr><td><div *ngFor="let payCost of paychecksCosts">PayCheck{{payCost.payCheckId}}-{{payCost.payCheckBenefitCost}}</div></td></tr>
      </table>
    </div>
  `,
  styleUrls: ['./empbenefit.component.css']
})
export class EmpbenefitComponent implements OnInit {

  constructor(private employeeservice:EmployeeService) { }

  ngOnInit(): void {
    this.employeeservice.getEmployees()
    .subscribe((data: any[])=>{
      console.log(data);
      this.employees = data;
    });  
  }
  public addEmployee(){
    let empName = (document.getElementById("employee")  as HTMLInputElement).value;
    let salary:any = (document.getElementById("salary")  as HTMLInputElement).value;
    if(empName == null || empName == "")
    {
      alert("Employee Name is Blank");
      return;
    }
    if(salary == null || salary == "" || isNaN(salary)){
      alert("Salary is not valid");
      return;
    }
    var y: number = +salary;
    this.employees.push(<IEmployee>{name: empName,annualPay: y, dependents:[]});
    console.log(this.employees);
  }
  public addDependent(emp:any){
    let depName = (document.getElementById("dependent")  as HTMLInputElement).value;
    if(depName == null || depName == "")
    {
      alert("Dependent Name is Blank");
      return;
    }
    let type;
    if(emp.dependents.length == 0){
      type = 0;
    }
    else{
      type = 1;
    }
    emp.dependents.push(<Dependent>{type: type,name: depName});
    console.log(emp);
  }

  public removeDependent(emp:any){
    if(emp.dependents.length == 0){
      alert("There are no dependents to remove");
      return;
    }   
    emp.dependents.pop() ;
  }

  getBenefitsSummary(emp:any){
    console.log(emp);
    this.employeeservice.getEmployeeBenefitSummary(emp)
    .subscribe((data: BenefitSummary)=>{
      console.log(data);
      this.benefitSummary = data;
      this.paychecksCosts = data.payCheckBenefitCosts;
      console.log(data.payCheckBenefitCosts);
    });
  }

  public employees:any[] = [];
  public benefitSummary:BenefitSummary;
  public paychecksCosts:PayCheckBenefit[];
}