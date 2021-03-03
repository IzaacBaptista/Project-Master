using System.Collections.Generic;

namespace Model
{
    public class LightVehicle : Vehicle {
        public int Id { set; get; }
        public string Color { set; get; }

        public static readonly List<LightVehicle> LightVehicles = new List<LightVehicle>();
        public LightVehicle(
            string Brand,
            string Model,
            int Year,
            double Price
        ) : base(Brand, Model, Year, Price) {
            this.Id = LightVehicles.Count;
            this.Color = Color;

            LightVehicles.Add(this);
        }

        public override string ToString()
        {
            return base.ToString() + "\nCor: " + this.Color;
        }

        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            LightVehicle lightVehicle = (LightVehicle) obj;
            return this.GetHashCode () == lightVehicle.GetHashCode ();
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

        public static List<LightVehicle> GetLightVehicles() {
            return LightVehicles;
        }
    }
}
