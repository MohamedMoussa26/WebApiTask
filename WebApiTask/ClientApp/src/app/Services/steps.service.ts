import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Instructions } from '../Models/Instructions';

@Injectable({
  providedIn: 'root'
})
export class StepsService {

  baseUrl: string;

  constructor(public httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  GetFirstStep(pageSize:number): Observable<Instructions[]> {
    return this.httpClient.get<Instructions[]>(this.baseUrl + 'api/Instructions/GetFirstStep?pageSize='+pageSize);
  }

  GetTaskDetails(): Observable<any> {
    return this.httpClient.get(this.baseUrl + 'api/Instructions/GetTaskDetails', { responseType : 'text' });
  }

}
