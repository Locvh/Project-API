using Project_API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Repositories;

namespace Services.Services
{
    public class GarageService : IGarageService
    {
        private readonly IGarageRepository _garageRepository;

        public GarageService(IGarageRepository garageRepository)
        {
            _garageRepository = garageRepository;
        }

        public async Task<Garage> AddGarageAsync(Garage newGarage)
        {
            return await _garageRepository.AddAsync(newGarage);
        }

        public async Task<List<Garage>> GetAllGaragesAsync()
        {
            return await _garageRepository.GetAllGarageAsync();
        }

        public async Task<Garage> GetGarageByIdAsync(int id)
        {
            return await _garageRepository.GetGarageByIdAsync(id);
        }
    }
}
