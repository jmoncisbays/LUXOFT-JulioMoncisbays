using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Luxoft_JMoncisbays_WebAPI.Models;

namespace Luxoft_JMoncisbays_WebAPI.Repositories
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Get();
    }
}
