using System;

namespace Luxoft_JMoncisbays_WebAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CompanyId { get; set; }
        public string Identifier { get; set; }
        public string Headline { get; set; }

        public Company Company { get; set; }
    }
}
