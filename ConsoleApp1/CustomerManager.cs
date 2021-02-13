using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName+"  Eklendi." );
        }
            
        public void List(Customer customer)
        {

            Console.WriteLine(customer.CustomerName + "  Listelendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "  Listelendi.");
        }
    }
}
