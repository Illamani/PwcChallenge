using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        [Route("CreateCar")]
        public void CreateCar(Car car)
        {
            _carService.Create(car);
        }

        [HttpGet]
        [Route("GetAllCar")]
        public async Task<List<Car>> GetCarsAsync(CancellationToken cancellationToken)
        {
            return await _carService.GetAll(cancellationToken);
        }

        [HttpGet]
        [Route("GetCar")]
        public async Task<Car> GetCarAsync(int id, CancellationToken cancellationToken)
        {
            return await _carService.Get(id, cancellationToken);
        }

        [HttpDelete]
        [Route("DeleteCar")]
        public void DeleteCar(Car car)
        {
            _carService.Delete(car);
        }

        [HttpPut]
        [Route("UpdateCar")]
        public void UpdateCar(Car car)
        {
            _carService.Update(car);
        }
    }
}
