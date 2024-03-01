using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            //property tutan class ekliyoruz.
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Yunus";
            customer.LastName = "Kaya";
            customer.City = "İstanbul";

            Customer customer2 = new Customer()
            {
                Id = 2, FirstName = "Hasan", LastName = "Kaya", City = "Kayseri"
            };
            Console.WriteLine(customer2.FirstName);
        }
    }
}