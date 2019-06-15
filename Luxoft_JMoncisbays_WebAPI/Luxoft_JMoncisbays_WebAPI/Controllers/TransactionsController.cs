using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Luxoft_JMoncisbays_WebAPI.Models;
using Luxoft_JMoncisbays_WebAPI.Repositories;

namespace Luxoft_JMoncisbays_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private ITransactionRepository _repository;

        public TransactionsController(ITransactionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetByPageAndFilter([FromQuery] string filter = "", int? pageSize = 10, int? page = 1)
        {
            string filterVal = filter ?? "";
            int pageSizeVal = pageSize ?? 10;
            int pageVal = page ?? 1;

            try
            {
                // calculate number of pages
                int rowCount = _repository.Get().Where(t => filterVal == "" || (t.Identifier == filter || t.Company.Name.Contains(filter) || t.Headline.Contains(filter))).Count();
                if (rowCount == 0)
                {
                    throw new Exception("Transaction records not found");
                }

                int pages = Convert.ToInt32(Decimal.Round(rowCount / pageSizeVal)) + (rowCount % pageSize == 0 ? 0 : 1);

                List<Transaction> transactions = _repository.Get()
                    .OrderByDescending(t => t.TransactionDate)
                    .Where(t => filterVal == "" || (t.Identifier == filter || t.Company.Name.Contains(filter) || t.Headline.Contains(filter)))
                    .Skip((pageVal - 1) * pageSizeVal)
                    .Take(pageSizeVal).ToList();

                return new JsonResult(new { rowCount, pages, transactions });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
