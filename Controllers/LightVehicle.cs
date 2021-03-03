using System;
using System.Collections.Generic;

namespace Controller
{
    public class LightVehicle
    {
        public static void CreateLightVehicle(
            string Brand,
            string Model,
            string Year,
            string Price,
            string Color,
            string Restrictions
        )
        {
            int ConvertYear = Convert.ToInt32(Year);
            double ConvertPrice = Convert.ToDouble(Price);

            if (ConvertYear < 1990) {
                throw new Exception("Carro muito antigo");
            }

            if (ConvertPrice < 0) {
                throw new Exception("Valor não pode ser negativo");
            }

            new Model.LightVehicle(
                Brand,
                Model,
                ConvertYear,
                ConvertPrice,
                Color,
                Restrictions
            );
        }

        public static List<Model.LightVehicle> GetLightVehicles() {
            return Model.LightVehicle.GetLightVehicles();
        }
    }
}
