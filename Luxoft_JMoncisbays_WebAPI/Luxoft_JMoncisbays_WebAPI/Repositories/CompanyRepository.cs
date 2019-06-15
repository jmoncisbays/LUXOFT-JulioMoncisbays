using System.Linq;
using Luxoft_JMoncisbays_WebAPI.Models;

namespace Luxoft_JMoncisbays_WebAPI.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private LuxoftJMoncisbaysDbContext _context;

        public CompanyRepository(LuxoftJMoncisbaysDbContext context)
        {
            _context = context;
        }

        IQueryable<Company> ICompanyRepository.Get() => _context.Companies;
    }
}
