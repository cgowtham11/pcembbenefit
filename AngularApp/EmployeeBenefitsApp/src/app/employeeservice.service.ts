import { BenefitSummary, IEmployee } from './employee';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Dependent } from './employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http:HttpClient) { }

  private _url:string = "http://localhost:64893/employee"

  getEmployees(): Observable<IEmployee[]>{
    return this.http.get<IEmployee[]>(this._url);
  }
  getEmployeeBenefitSummary(emp:IEmployee): Observable<BenefitSummary>{
    return this.http.post<BenefitSummary>(this._url, emp);
  }

}
