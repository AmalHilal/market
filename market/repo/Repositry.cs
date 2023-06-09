using market.Data;
using market.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.repo
{
    internal class Repositry
    {
        MyDbContext db;
      public  Repositry (MyDbContext db)
        {
            this.db = db;
        }
        public void saveCar(Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
        }
        public void deleteCar(Car car)
        {
            db.Cars.Remove(car);
            db.SaveChanges();
        }
        public void saveCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }
        public void saveSales(Sale sale)
        {
            db.Sales.Add(sale);
            db.SaveChanges();
        }
        public void savePart(Part part)
        {
            db.Parts.Add(part);
            db.SaveChanges();
        }
    }
}
