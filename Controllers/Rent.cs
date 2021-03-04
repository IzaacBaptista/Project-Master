using System;
using System.Collections.Generic;

namespace Controllers
{
    public class Rent
    {
        public static Model.Rent CreatRent(
            string IdCustomer,
            string StringRentDate
        )  
        {
            Model.Customer Customer = Controllers.Customer.GetCustomer(Convert.ToInt32(IdCustomer));
            
            DateTime RentDate = DateTime.Today;

            return new Model.Rent.Rent(Customer, RentDate);
        }

        public static List<Models.Rent> GetRents()
        {
            return Models.Rent.GetRents();
        }
    }
}