using Data.Entities;
using Labolatorium3_app.Models;

namespace Labolatorium3_app.Models
{
    public class CarMapper
    {
        public static CarEntity ToEntity(Car model)
        {
            return new CarEntity()
            {
                CarId = model.Id,
                Model = model.Model,
                Manufacturer = model.Manufacturer,
                EngineCapacity = model.EngineCapacity,
                Power = model.Power,
                RegistrationNumber = model.RegistrationNumber,
                Owner = model.Owner,
            };
        }

        public static Car FromEntity(CarEntity entity)
        {
            return new Car()
            {
                Id = entity.CarId,
                Model = entity.Model,
                Manufacturer = entity.Manufacturer,
                EngineCapacity = entity.EngineCapacity,
                Power = entity.Power,
                RegistrationNumber = entity.RegistrationNumber,
                Owner = entity.Owner,

            };
        }
    }
}
