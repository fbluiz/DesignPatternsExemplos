namespace AbstractFactory.Models
{
    public abstract class Alimento : Produto
    {
        public decimal Calorias { get; set; }
        public bool AltoEmGoduraSaturada { get; set; }

        public Alimento(decimal preco, int identificador, string nome, decimal calorias, bool altoEmGorduraSaturada) : base(preco, identificador, nome, Enums.TipoProduto.Alimento)
        {
            Calorias = calorias;
            AltoEmGoduraSaturada = altoEmGorduraSaturada;
        }
    }
}
