using market.Data;
using market.Domain;
using market.repo;

namespace market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext myDb = new MyDbContext())
            {


                myDb.Database.EnsureCreated();



                var carsRepo = new Repositry(myDb);


                carsRepo.saveCar(new Car()
                {

                    Gear = "myGear",

                    Km = 200,

                    Model = "12121212",

                    Parts = new List<Part>
            {
                new Part() {
                    Name = "name",
                     Quntity=120,

                    Price=111.2,
                    supplierModel=new Supplier()
                    {       Address="address",
                           Name="aaa"
                    }
                },
                  new Part() {
                    Name = "part",
                    Price=14.2,
                    Quntity=1200,
                    supplierModel=new Supplier()
                    {
                           Address="test Address",
                           Name="karim"
                    }
                }
            }

                });




            }
        }
    }
}