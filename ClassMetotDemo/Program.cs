using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { };
            customer1.Id = 1;
            customer1.name = "Serkan";
            customer1.surName = "Aydın";
            customer1.age = 24;

            Customer customer2 = new Customer { };
            customer2.Id = 2;
            customer2.name = "Yunus";
            customer2.surName = "Tuncay";
            customer2.age = 25;

            Customer customer3 = new Customer { };
            customer3.Id = 3;
            customer3.name = "Ahmet";
            customer3.surName = "Günindi";
            customer3.age = 20;

            Customer customer4 = new Customer { };
            customer4.Id = 4;
            customer4.name = "Mehmet";
            customer4.surName = "Tarhan";
            customer4.age = 32;

            Customer customer5 = new Customer { };
            customer4.Id = 5;
            customer4.name = "Volkan";
            customer4.surName = "Aydın";
            customer4.age = 36;

            Customer[] customer = new Customer[] {customer1,customer2,customer3,customer4 };

            CustomerManager customerManager = new CustomerManager { };
            customerManager.List(customer);
            customerManager.Added(customer1);
            customerManager.Deleted(customer3);
            customerManager.Added(customer2);
            
            


        }
    }
}
