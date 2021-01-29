using Microsoft.EntityFrameworkCore;
using Project_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern.Repositories
{
    public class GarageRepository : Repository<Garage>, IGarageRepository
    {
        public GarageRepository(CarRentalContext CarRentalContext) : base(CarRentalContext)
        {
        }
        public async Task<List<Garage>> GetAllGarageAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Garage> GetGarageByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.GarageId == id);
        }

    }
}
