using RentalCar.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.Domain.Entities
{
	public class Car : BaseEntity
	{
		public int ServiceId { get; set; }

		[ForeignKey("ServiceId")]
		public ICollection<RentalService> Services { get; set; }

		public string Type { get; set; }

		public string Model { get; set; }
	}
}
