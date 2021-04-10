using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            //RentDetailTest();
            //RentalAdded();
            //RentalTest();
            //UserTest();
            //CustomerTest();
            //ColorAdded();
            //BrandAdded();
            //CarAdded();
            CarTest();
            //ColorTest();
            //BrandTest();

            Console.ReadLine();
        }

        private static void RentDetailTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var detail in rentalManager.GetRentalDetail().Data)
            {
                Console.WriteLine(detail.Id);
                Console.WriteLine(detail.CarName);
                Console.WriteLine(detail.CompanyName);
                Console.WriteLine(detail.RentDate);
                Console.WriteLine(detail.ReturnDate);
                Console.WriteLine("----------------------------");
            }
        }

        private static void RentalAdded()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId = 3,
                CustomerId = 2,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(10)
            });
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rent in rentalManager.GetAll().Data)
            {
                Console.WriteLine("{0}  |  {1}  |  {2}  |  {3}  |  {4}", rent.Id, rent.CustomerId, rent.CarId, rent.RentDate, rent.ReturnDate);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAllUser().Data)
            {
                Console.WriteLine("{0}  |  {1}  |  {2} ", user.FirstName, user.LastName, user.Email);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("{0} --- {1}", customer.UserId, customer.CompanyName);
            }
        }

        private static void ColorAdded()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color
            {
                Name = "Yeşil"
            });
            if (true)
            {
                Console.WriteLine("renk kaydı başarılı");
            }
        }

        private static void BrandAdded()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(
                new Brand
                {
                    Name = "Volkswagen"
                });
            if (true)
            {
                Console.WriteLine("marka kaydı başarılı");
            }
        }

        private static void CarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                CarName = "Symbol",
                BrandId = 5,
                ColorId = 2,
                DailyPrice = 230,
                ModelYear = "2015",
                Description = "deneme"
            });

            if (true)
            {
                Console.WriteLine("yeni araç kaydı başarılı");
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetBrands().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void ColorTest()
        {
            ColorManager colors = new ColorManager(new EfColorDal());
            foreach (var color in colors.GetColors().Data)
            {
                Console.WriteLine(color.Name);
            }

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} / {1} / {2} / {3}", car.ProductId, car.CarName, car.BrandName, car.ColorName);
            }
        }
    }
}
