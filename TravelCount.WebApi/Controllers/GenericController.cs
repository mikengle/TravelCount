using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TravelCount.WebApi.Controllers
{
    public abstract class GenericController<I,M>:ControllerBase
        where M:Transfer.TransferObject,I,Contracts.ICopyable<I>,new()
        where I:Contracts.IIdentifiable
    {
        protected Contracts.Client.IControllerAccess<I> CreateController()
        {
            return Logic.Factory.Create<I>();
        }

        protected async Task<int> CountAsync()
        {
            using var ctrl = CreateController();
            return await ctrl.CountAsync();
        }

        protected async Task<IEnumerable<I>> GetAllAsync()
        {
            using var ctrl = CreateController();
            return await ctrl.GetAllAsync();
        }

        protected Task<I> GetByIdAsync(int id)
        {
            using var ctrl = CreateController();
            return ctrl.GetByIdAsync(id);
        }

        public async Task InsertAsync([FromBody] M model)
        {
            using var ctrl = CreateController();
            await ctrl.InsertAsync(model);
            await ctrl.SaveChangesAsync();
        }
        public async Task UpdateAsync(int id, [FromBody] M model)
        {
            using var ctrl = CreateController();
            await ctrl.UpdateAsync(model);
            await ctrl.SaveChangesAsync();
        }
        public async Task DeleteByIdAsync(int id)
        {
            using var ctrl = CreateController();
            await ctrl.DeleteAsync(id);
            await ctrl.SaveChangesAsync();
        }

    }
}
