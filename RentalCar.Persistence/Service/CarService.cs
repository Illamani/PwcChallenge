using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Application.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service
{
	public class CarService : ICarService
	{
		private readonly ICarRepository _carRepository;
		public CarService(ICarRepository carRepository) {
			_carRepository = carRepository;
		}

		public void Create(Car entity) {
			_carRepository.Create(entity);
		}

		public void Update(Car entity)
		{
			_carRepository.Update(entity);
		}

		public void Delete(Car entity)
		{
			_carRepository.Delete(entity);
		}

		public Task<Car> Get(int id, CancellationToken cancellationToken)
		{
			return _carRepository.Get(id, cancellationToken);
		}

		public Task<List<Car>> GetAll(CancellationToken cancellationToken)
		{
			return _carRepository.GetAll(cancellationToken);
		}
	}
}
