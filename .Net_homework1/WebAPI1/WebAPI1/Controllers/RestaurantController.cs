using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using WebAPI1.DataAccessLayer;
using WebAPI1.Entities;

namespace WebAPI1.Controllers
{
    [ApiController]
    [Route("api/restaurants")]
    public class RestaurantController : ControllerBase

    {
        private DataContext _dbContext = new DataContext();
        public RestaurantController()
            {

            }
        [HttpPost]
        public async Task<IActionResult> CreateRestaurant([FromBody] Restaurant restaurant)
        {
            _dbContext.Restaurants.Add(restaurant);
           await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateRestaurant), new { id = restaurant.Id }, restaurant);
        }
    }
    


    
}
