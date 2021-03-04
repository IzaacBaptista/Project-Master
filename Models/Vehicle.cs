namespace Model 
{
    public abstract class Vehicle {
        protected string Brand { set; get; } // Marca
        protected string Model { set; get; } // Modelo
        protected int Year { set; get; }     // Ano
        protected double Price { set; get; } // Valor para locação
        //protected string Color { set; get; } // Cor

        protected Vehicle(
            string Brand,
            string Model,
            int Year,
            double Price
            //string Color 
        ) 
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
           // this.Color = Color;
        }

        public override string ToString() {
            return
                "Marca: "              + this.Brand +
                "\nModelo: "           + this.Model +
                "\nAno: "              + this.Year +
                "\nPreço de Locação: " + this.Price;
                //"\nCor: "              + this.Color;
        }
    }
}