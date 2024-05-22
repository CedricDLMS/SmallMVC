using CrudMVCClean.Models;

namespace CrudMVCClean.Repository
{
	public class FaceRepository
	{
		private readonly HumainContext _context;
		public FaceRepository(HumainContext context)
		{
			this._context = context;
		}

		public async Task<int> CreateAsync(Face face)
		{
			await _context.Faces.AddAsync(face);
			return await _context.SaveChangesAsync();
		}

		public async Task<Face?> GetAsync(int id)
		{
			return await _context.Faces.FindAsync(id);
		}
	}
}
