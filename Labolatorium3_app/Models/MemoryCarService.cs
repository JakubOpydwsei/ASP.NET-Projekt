using System;
using System.Collections.Generic;
using System.Linq;
using Data.Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Labolatorium3_app.Models
{
    public class MemoryCarService : ICar  
    {
        private Dictionary<int, Car> _items = new Dictionary<int, Car>();

        public int Add(Car car)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            car.Id = id + 1;
            _items.Add(car.Id, car);
            return car.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Car> FindAll()
        {
            return _items.Values.ToList();
        }


        public Car? FindById(int id) 
        {
            return _items.ContainsKey(id) ? _items[id] : null;
        }

        public void Update(Car car) 
        {
            _items[car.Id] = car;
        }
    }
}
