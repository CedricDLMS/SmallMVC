using CrudMVCClean.Models;

namespace CrudMVCClean.Repository
{
	public class HumainRepository
	{
		private readonly HumainContext _context;
		public HumainRepository(HumainContext context)
		{
			this._context = context;
		}

		public async Task<int> CreateAsync(Humain humain)
		{
			await _context.Humains.AddAsync(humain);
			return await _context.SaveChangesAsync();
		}

		public async Task<Humain?> GetAsync(int id)
		{
			return await _context.Humains.FindAsync(id);
		}
	}
}
