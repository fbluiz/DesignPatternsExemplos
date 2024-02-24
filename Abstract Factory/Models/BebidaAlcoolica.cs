namespace AbstractFactory.Models
{
    sealed class BebidaAlcoolica : Alimento
    {
        public decimal QuantidadeEmLitros { get; set; }
        public decimal TeorAlcoolicoEmPorcentagem { get; set; }

        public BebidaAlcoolica() : base(90, 2, "Vodka Absolut", 350, false)
        {
            QuantidadeEmLitros = 1;
            TeorAlcoolicoEmPorcentagem = 45;
        }
    }
}
