using Project_API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
   public interface IGarageService
    {
        Task<List<Garage>> GetAllGaragesAsync();
        Task<Garage> GetGarageByIdAsync(int id);
        Task<Garage> AddGarageAsync(Garage newGarage);
    }
}
