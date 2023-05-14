namespace Parcial3_SalazarVasquezJuanPablo.DAL
{
    public class SeederDB
    {
        private readonly DatabaseContext _context;

        public SeederDB(DatabaseContext context)
        {
            _context = context;
        }

        public async Task seederAsync()
        {
            await _context.Database.EnsureCreatedAsync();
        }
    }
}
