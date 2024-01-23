using Data.Entities;

namespace Labolatorium3_app.Models
{
    public interface ICar
    {
        int Add(Car car);
        void Delete(int id);
        void Update(Car car);
        List<Car> FindAll();
        Car? FindById(int id);
    }
}
