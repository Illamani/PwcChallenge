namespace RentalCar.Models
{
	public class Car
	{
		public ICollection<Service> Services { get; set; }

		public string Type { get; set; }

		public string Model { get; set; }
	}
}
