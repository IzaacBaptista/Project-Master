using System;
using System.Collections.Generic;

namespace Controllers
{
    public class Rent
    {
        public static Models.Rent CreatRent(
            string IdCustomer,
            string StringRentDate
        )  
        {
            Models.Customer Customer = Controllers.Customer.GetCustomer(Convert.ToInt32(IdCustomer));
            
            DateTime RentDate = DateTime.Today;

            return new Models.Rent(Customer, RentDate);
        }

        public static List<Models.Rent> GetRents()
        {
            return Models.Rent.GetRents();
        }
    }
}