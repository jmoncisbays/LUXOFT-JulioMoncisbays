using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxoft_JMoncisbays_WebAPI.Models
{
    public class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public ICollection<Transaction> Transactions { get; set; }
    }
}
