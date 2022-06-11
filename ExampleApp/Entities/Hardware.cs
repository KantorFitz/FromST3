namespace ExampleApp.Entities
{
	public class Hardware
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Year { get; set; }
		public string NumberOfItems { get; set; }
		public decimal Price { get; set; }
		
		public int CompanyId { get; set; }
	}
}