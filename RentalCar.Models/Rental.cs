namespace RentalCar.Models
{
	public class Rental
	{
		public Customer	Customer { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public Car Car { get; set; }
	}
}
