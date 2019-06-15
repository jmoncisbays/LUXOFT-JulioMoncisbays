import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from "rxjs";
import { catchError } from 'rxjs/operators';
import { environment } from '../../../environments/environment';
import { HttpBodyResponse } from '../../models/transaction';

const url = environment.webapiUrl;

@Injectable({
  providedIn: 'root'
})
export class WebapiService {

  constructor(private httpClient: HttpClient) { }

  getTransactions(filter: string, pageSize: number, page: number): Observable<HttpBodyResponse> {
    return this.httpClient.get<HttpBodyResponse>(`${url}/transactions?filter=${encodeURI(filter)}&pagesize=${pageSize}&page=${page}`).pipe(catchError(this.handleError));;
  }

  private handleError(error: HttpErrorResponse) {
    let errorMsg: string;

    // no response from WebAPI server
    if (error.status == 0) {
      errorMsg = "Please run the Backend application";
    }
    else if (error.error instanceof ErrorEvent) {
      console.error('An error occurred:', error.error.message);
      errorMsg = error.error.message;
    }
    else {
      console.error(`Backend returned code ${error.status}, body was: ${error.error}`);
      errorMsg = error.error;
    }

    return throwError(errorMsg);
  };
}
