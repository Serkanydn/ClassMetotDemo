using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Added(Customer customer)
        {
            Console.WriteLine("---------- Müşteri Ekleme Sistemi ----------");
            Console.WriteLine(customer.Id + " : Idli Müşteri Eklendi.");
            Console.WriteLine("                                            ");

        }

        public void List(Customer[] customer)
        {
            Console.WriteLine("---------- Müşteriler Listelendi. ----------");
            foreach (var customers in customer)
            {

                Console.WriteLine(customers.Id + " " + customers.name + " " + customers.surName + " " + customers.age);

            }
            Console.WriteLine("                                            ");
        }
        public void Deleted(Customer customer)
        {
            Console.WriteLine("---------- Müşteri Silme Sistemi ----------");
            Console.WriteLine(customer.Id + " : Idli Müşteri Silindi.");
            Console.WriteLine("                                            ");

        }

    }
}
