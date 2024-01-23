using Data.Entities;
using Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Labolatorium3_app.Models
{
    public class EFCarService : ICar
    {
        private AppDbContext __ctx;

        public EFCarService(AppDbContext ctx)
        {
            __ctx = ctx;
        }

        public int Add(Car car)
        {
            var e = __ctx.Cars.Add(CarMapper.ToEntity(car));
            int id = e.Entity.CarId;
            __ctx.SaveChanges();
            return id;
        }

        public void Delete(int id)
        {
            CarEntity? find = __ctx.Cars.Find(id);
            if (find != null)
            {
                __ctx.Cars.Remove(find);
                __ctx.SaveChanges();
            }
        }

        public List<Car> FindAll()
        {
            return __ctx.Cars
                .Select(e => CarMapper.FromEntity(e))
                .ToList();
        }

        public Car? FindById(int id)
        {
            CarEntity? find = __ctx.Cars.Find(id);
            return find != null ? CarMapper.FromEntity(find) : null;
        }

        public void Update(Car car)
        {
            __ctx.Cars.Update(CarMapper.ToEntity(car));
            __ctx.SaveChanges();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            return __ctx.Organizations.ToList();
        }
    }
}
