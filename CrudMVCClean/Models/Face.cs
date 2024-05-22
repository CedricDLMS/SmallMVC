namespace CrudMVCClean.Models
{
	public class Face
	{
		public int Id { get; set; }
		public string Name { get; set; } = "not Defined";
		public string Content { get; set; } = "not Defined";
		// EF 

		public List<Humain>? Humains { get; set; }
	}
}
