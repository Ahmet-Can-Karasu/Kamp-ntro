using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="AhmetCan",
                LastName="Karasu",City="İstanbul" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ahmet";
            customer3.LastName = "Karasu";
            customer3.City = "İstanbul";

            Customer customer2 = new Customer(2,"Sudem","Karasu","İstanbul");
            Console.WriteLine(customer2.FirstName);
        }

        //static void Method(int Id, string firtsName, string lastName, string city)
        //{ 

        //}
    }

    class Customer
    {
        public Customer()
        {

        }


        public Customer(int id,string firstName,string lastname,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
