using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("congratulations! you are add our website :" + "\t" + customer.Name );
            }
        }
        public void Delete(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("unfortunately You are deleted our website :" + "\t" + customer.Name );
            }
        }
        public void List(Customer[] customers)
        {
            Console.WriteLine("Customer listed!");
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer ID :" + "\t" + customer.Id);
                Console.WriteLine("Customer Name :" + "\t" + customer.Name);
                Console.WriteLine("Customer Lastname :" + "\t" +customer.LastName);
                Console.WriteLine("Customer Gender :" + "\t" + customer.Gender);
                Console.WriteLine("Customer Borth Date :" + "\t" + customer.BorthDay);
            }
        }
        public void Update(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer :" + customer.Name + "  name changed. ");
            }
        }

    }
}
