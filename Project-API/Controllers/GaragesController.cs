using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_API.Models;
using Services.Services;

namespace Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaragesController : ControllerBase
    {
        private readonly IGarageService _garageService;

        public GaragesController(IGarageService garageService)
        {
            _garageService = garageService;
        }
        [HttpPost]
        public async Task<ActionResult<Garage>> CreateGarage()
        {
            var garage = new Garage
            {
                GarageId = 31,
                Address = "Loccczxcz",
                Description = "Vo xzxczc",
                ImageLink = "sdds"
            };

            return await _garageService.AddGarageAsync(garage);
        }
        [HttpGet]
        public async Task<ActionResult<List<Garage>>> GetAllGarages()
        {
            return await _garageService.GetAllGaragesAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Garage>> GetGarageById(int id)
        {
            return await _garageService.GetGarageByIdAsync(id);
        }
    }
}