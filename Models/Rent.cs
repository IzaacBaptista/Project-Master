using System;
using System.Collections.Generic;
namespace Models
{
    public class Rent
    {
        public int Id { set; get;}
        public Customer Customer { set; get; }
        public DateTime RentDate { set; get; }
        //public static readonly List<Rent> Rents = new ();
        public static readonly List<Rent> Rents = new List<Rent>();

        public Rent(
            Customer Customer, 
            DateTime RentDate
        ) {
            this.Customer = Customer;
            this.RentDate = RentDate;

            Rents.Add(this);
        }

        public override ToString()
        {
            return String.Format(
                "Data de locação: {0}\nClient: {1}",
                this.RentDate,
                this.Customer
            );
        }


        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            Rent rent = (Rent) obj;
            return this.GetHashCode () == rent.GetHashCode ();
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = (int) 2166136261;
                // Suitable nullity checks etc, of course :)
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }

        public static List<Rent> GetRents() {
            return Rent;
        }

    }
}