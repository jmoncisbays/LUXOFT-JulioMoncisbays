using System.Linq;
using Microsoft.EntityFrameworkCore;
using Luxoft_JMoncisbays_WebAPI.Models;

namespace Luxoft_JMoncisbays_WebAPI.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private LuxoftJMoncisbaysDbContext _context;

        public TransactionRepository(LuxoftJMoncisbaysDbContext context)
        {
            _context = context;
        }

        IQueryable<Transaction> ITransactionRepository.Get() => _context.Transactions.Include(t => t.Company);
    }
}
