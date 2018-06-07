using System;
using ShipperApplicationLibrary.Shipments;
using ShipperApplicationLibrary.Users;


namespace ShipperApplication.cs
{
    class ShipperApplication
    {
        public static string user_Id;
        static void Main(string[] args)
        {
            Shipper customer = new Shipper();

            Driver ID = new Driver();
            Console.WriteLine("Enter the user type\n");
            Console.WriteLine("customer\n");
            Console.WriteLine("driver\n");
            user_Id = Console.ReadLine();
            if (user_Id == "customer")
            {
                customer.Login();
                customer.Place_order();

            }
            else if (user_Id == "driver")
            {
                ID.Login();
                ID.Accept_order();
            }


            Console.ReadKey();

        }
    }
}
