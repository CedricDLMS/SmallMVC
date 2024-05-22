using Microsoft.EntityFrameworkCore;

namespace CrudMVCClean.Models
{
	public class HumainContext : DbContext
	{
		public DbSet<Humain> Humains { get; set;}
		public DbSet<Face> Faces { get; set;}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HumainDb;Trusted_Connection=True;");
		}

	}
}
