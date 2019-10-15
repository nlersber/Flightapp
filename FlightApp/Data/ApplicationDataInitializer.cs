using FlightApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data
{
    public class ApplicationDataInitializer
    {

        private readonly ApplicationDbContext _dbContext;
        //private readonly UserManager<User> _userManager;

        public ApplicationDataInitializer(ApplicationDbContext dbContext/*, UserManager<User> userManager*/)
        {
            _dbContext = dbContext;
            //_userManager = userManager;
        }

        public async Task InitializeData()
        {
            //databank seeding 
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                //this flight
                //Flight thisFlight = new Flight("destination", "origin", 250, DateTime.Now);

                //movies
                Entertainment theJoker = new Entertainment("Joker", "movie about why the most famous villain of gotham became the Joker",
                    "Comics", Enums.EntertainmentType.Movie, 120);
                //series
                Entertainment Gotham = new Entertainment("Gotham Pilot", "Serie about Gotham when Bruce is growing up",
                    "Comics", Enums.EntertainmentType.Serie, 45);
                //music
            }

        }

        //private async Task createUser(User user, string password)
        //{
        //    await _userManager.CreateAsync(user, password);
        //}
    }
}
