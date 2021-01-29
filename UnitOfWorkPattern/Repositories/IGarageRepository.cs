using Project_API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern.Repositories
{
   public interface IGarageRepository : IRepository<Garage>
    {
        Task<Garage> GetGarageByIdAsync(int id);

        Task<List<Garage>> GetAllGarageAsync();
    }
    
}
