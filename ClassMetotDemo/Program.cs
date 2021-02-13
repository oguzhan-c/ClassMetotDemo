using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = 1;
            customer1.Name = "Denizhan";
            customer1.LastName = "Saraç";
            customer1.Gender = "Male";
            customer1.BorthDay= Microsoft.VisualBasic.DateAndTime.DateSerial(1998,02,12);

            Customer customer2 = new Customer();

            customer2.Id = 2;
            customer2.Name = "Oğuzhan";
            customer2.LastName = "Can";
            customer2.Gender = "Male";
            customer2.BorthDay = Microsoft.VisualBasic.DateAndTime.DateSerial(1999, 01, 04);

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customers);
            customerManager.Delete(customers);
            customerManager.Update(customers);
            customerManager.List(customers);

            Console.ReadLine();

        }
    }
}
