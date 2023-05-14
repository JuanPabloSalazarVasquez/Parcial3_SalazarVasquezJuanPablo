using Parcial3_SalazarVasquezJuanPablo.Helpers;

namespace Parcial3_SalazarVasquezJuanPablo.DAL.Entities
{
    public class SeederDb
    {

        private readonly DatabaseContext _context;
        private readonly IUserHelper _userHelper;

        public SeederDb(DatabaseContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await populateRolesAsync();

            //await PopulateUserAsync();
        }

        /*private async Task PopulateUsersAsync()
        {
            if (!_context.Users.Any())
            {
                _context.Users.Add(new User { Name = 'John Doe', Type = 'Client' });
                _context.Users.Add(new User { Name = 'Admin Doe', Type = 'Admin' });
            }
        }*/
    }
}
