using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Buğra";
            customer1.CustomerSurname = "Kömürcü";
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
        }

    }
}
