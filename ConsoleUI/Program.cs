using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
     class Program
    {
        static void Main(string[] args)
        {
            //test1();
            //test2();
            //test3();

           
        }

        private static void test3()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            var result = carManager.GetAll();

            foreach (var car in result)
            {
                Console.WriteLine(car.Descriiption);
            }
        }

        private static void test2()
        {
            CarManager carManager1 = new CarManager(new EFCarDal());
            carManager1.Add(new Car { CarId = 3, BrandId = 1, ColorId = 1, ModelYear = "2008", DailyPrice = 0, Descriiption = "Best paket" });

            foreach (var cars in carManager1.GetAll())
            {
                Console.WriteLine(cars.Descriiption);
            }
        }

        private static void test1()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine(carManager.GetCarById(2).Descriiption);
            Console.WriteLine("------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriiption);
            }
        }
    }
}
