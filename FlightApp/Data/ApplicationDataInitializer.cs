using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data
{
    public class ApplicationDataInitialiser
    {

        private readonly ApplicationDbContext _dbContext;
        //private readonly UserManager<User> _userManager;

        public ApplicationDataInitialiser(ApplicationDbContext dbContext/*, UserManager<User> userManager*/)
        {
            _dbContext = dbContext;
            //_userManager = userManager;
        }

        public async Task InitializeData()
        {
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                //databank seeding 
            }

        }

        //private async Task createUser(User user, string password)
        //{
        //    await _userManager.CreateAsync(user, password);
        //}
    }
}
