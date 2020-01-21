using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contract = TravelCount.Contracts.Persistence.IExpense;
using Model = TravelCount.Transfer.Persistence.Expense;

namespace TravelCount.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : GenericController<Contract, Model>
    {
        [HttpGet("/api/[controller]/count")]
        public Task<int> GetCountAsync()
        {
            return CountAsync();
        }

        // https://localhost:5001/api/expense/get
        [HttpGet("/api/[controller]/Get")]
        public Task<IEnumerable<Contract>> GetAsync()
        {
            return GetAllAsync();
        }

        // GET: api/Expense/1
        [HttpGet("{id:int}")]
        public Task<Contract> Get(int id)
        {
            return GetByIdAsync(id);
        }

        // POST: api/Expense
        [HttpPost]
        public Task Post([FromBody] Model model)
        {
            return InsertAsync(model);
        }

        // PUT: api/Expense/1
        [HttpPut("/api/[controller]/PutAsync/{id}")]
        public Task PutAsync(int id, [FromBody] Model model)
        {
            return UpdateAsync(id, model);
        }

        // DELETE: api/Expense/1
        [HttpDelete("/api/[controller]/DeleteAsync/{id}")]
        public Task DeleteAsync(int id)
        {
            return DeleteByIdAsync(id);
        }
    }
}