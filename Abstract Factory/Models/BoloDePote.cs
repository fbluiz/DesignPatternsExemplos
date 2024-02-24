namespace AbstractFactory.Models
{
    sealed class BoloDePote : Alimento
    {
        public string Sabor { get; set; }

        public BoloDePote() : base(10, 1, "Bolo de Pote Sabor Chcolate", 450, true)
        {
            Sabor = "Chocolate";
        }

    }
}
