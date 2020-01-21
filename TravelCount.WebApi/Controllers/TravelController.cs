using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contract = TravelCount.Contracts.Persistence.ITravel;
using Model = TravelCount.Transfer.Persistence.Travel;

namespace TravelCount.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TravelController:GenericController<Contract,Model>
    {
        [HttpGet("/api/[controller]/count")]
        public Task<int> GetCountAsync()
        {
            return CountAsync();
        }

        // https://localhost:5001/api/travel/get
        [HttpGet("/api/[controller]/Get")]
        public Task<IEnumerable<Contract>> GetAsync()
        {
            return GetAllAsync();
        }

        // GET: api/Travel/1
        [HttpGet("{id:int}")]
        public Task<Contract> Get(int id)
        {
            return GetByIdAsync(id);
        }

        // POST: api/Travel
        [HttpPost]
        public  Task Post([FromBody] Model model)
        {
            return InsertAsync(model);
        }

        // PUT: api/Travel/1
        [HttpPut("/api/[controller]/PutAsync/{id}")]
        public Task PutAsync(int id, [FromBody] Model model)
        {
            return UpdateAsync(id, model);
        }

        // DELETE: api/Travel/1
        [HttpDelete("/api/[controller]/DeleteAsync/{id}")]
        public Task DeleteAsync(int id)
        {
            return DeleteByIdAsync(id);
        }
    }
}
