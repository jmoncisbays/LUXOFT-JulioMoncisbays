import { Injectable } from '@angular/core';
import { WebapiService } from './webapi.service';
import { HttpBodyResponse } from '../../models/transaction';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TransactionsService {

  constructor(private webApi: WebapiService) { }

  get(filter: string, pageSize: number, page: number): Observable<HttpBodyResponse> {
    return this.webApi.getTransactions(filter, pageSize, page);
  }
}
