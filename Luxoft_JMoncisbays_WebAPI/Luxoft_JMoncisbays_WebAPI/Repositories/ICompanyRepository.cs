using System.Linq;
using Luxoft_JMoncisbays_WebAPI.Models;

namespace Luxoft_JMoncisbays_WebAPI.Repositories
{
    public interface ICompanyRepository
    {
        IQueryable<Company> Get();
    }
}
