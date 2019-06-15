import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSnackBarModule, MatPaginatorModule } from '@angular/material';

import { AppComponent } from './app.component';
import { TransactionComponent } from './components/transaction/transaction.component';
import { HeadlinePreviewPipe } from './pipes/headline-preview.pipe';

@NgModule({
  declarations: [
    AppComponent,
    TransactionComponent,
    HeadlinePreviewPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatSnackBarModule,
    MatPaginatorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
