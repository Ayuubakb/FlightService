using Microsoft.AspNetCore.Mvc;
using FlightSearchAPI.DTOs;
using FlightSearchAPI.Services;

namespace FlightSearchAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly AmadeusFlightService _flightService;

        public FlightController(AmadeusFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchFlights(string origin, string destination, string departureDate, Boolean oneWay, string gobackDate,int adults)
        {
            var result = await _flightService.SearchFlightsAsync(origin, destination, departureDate, oneWay, gobackDate, adults);
           
            return Ok(result);
        }
    }
}
