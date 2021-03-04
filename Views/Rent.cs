using System;
using System.Collections.Generic;

namespace Views
{
    public class Rent
    {
        public static void CreateRent()
        {
            System.Console.WriteLine("Insira o Id do cliente");
            string IdCustomer = Console.ReadLine();
            System.Console.WriteLine("Insira a data de locação");
            string RentDate = Console.ReadLine();
        }

        public static void ListRents()  
        {
            List<Model.Rent> Rents = Controller.Rent.GetRents();

            foreach (Model.Rent Rent in Rents)
            {
                System.Console.WriteLine("--------------------------------------");
                System.Console.WriteLine(Rent);
            }
        }
    }
}