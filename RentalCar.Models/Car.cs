using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentalCar.Models
{
	public class Car
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public int ServiceId { get; set; }

		[ForeignKey("ServiceId")]
		public ICollection<Service> Services { get; set; }

		public string Type { get; set; }

		public string Model { get; set; }
	}
}
