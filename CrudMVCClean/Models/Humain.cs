namespace CrudMVCClean.Models
{
	public class Humain
	{
		public int Id { get; set; }
		public string Name { get; set; } = "not Defined";
		public string Description { get; set; } = "Empty Description";
		
		// EF NAVIGATION
		public int? FaceId { get; set; }
		public Face? Face { get; set; }
	}
}
