import { Company } from './company';

export class Transaction {
  constructor() {};

  public id: number;
  public transactionDate: Date;
  public company: Company;
  public identifier: string;
  public headline: string;
}

export class HttpBodyResponse {
  constructor() {};

  public rowCount: number;
  public pages: number;
  public transactions: Transaction[];
}