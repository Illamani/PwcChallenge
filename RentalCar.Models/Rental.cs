using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentalCar.Models
{
	public class Rental
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public int CustomerId { get; set; }

		[ForeignKey("CustomerId")]
		public Customer	Customer { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int CarId { get; set; }

		[ForeignKey("CarId")]
		public Car Car { get; set; }
	}
}
