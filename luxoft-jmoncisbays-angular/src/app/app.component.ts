import { Component, OnInit, ViewChild } from '@angular/core';
import { TransactionsService } from './services/repositories/transactions.service';
import { Transaction } from './models/transaction';
import { MatSnackBar } from '@angular/material';
import { environment } from '../environments/environment';
import { MatPaginator, PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  filter: string = "";
  pageSize: number = environment.pageSize;
  rowCount: number;
  pageSizeOptions: number[] = [5, 10, 20, 50];
  pageEvent: PageEvent;
  transactions: Transaction[];
  
  @ViewChild("paginator", {static: false}) paginator: MatPaginator;
  
  constructor(private repo: TransactionsService, private snackBar: MatSnackBar) {}

  ngOnInit() {
    this.loadTransactions();
  }

  loadTransactions(page = 1) {
    this.repo.get(this.filter, this.pageSize, page).subscribe(data => {
      this.rowCount = data.rowCount;
      if (page == 1) {
        this.paginator.firstPage();
      }
      this.transactions = data.transactions;
    }, (error => {
      // clear current results
      this.transactions = [];
      this.rowCount = 0;

      this.handleRepoError(error);
    }));
  }

  clearSearch() {
    this.filter = "";
    this.loadTransactions();
  }

  pageChanged(pageData: PageEvent) {
    this.pageSize = pageData.pageSize;
    this.loadTransactions(pageData.pageIndex + 1);
  }

  handleRepoError(errorMsg: string) {
    this.snackBar.open(errorMsg, "", {
      duration: 3000
    });
  }
}
