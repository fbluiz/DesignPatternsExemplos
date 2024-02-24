using AbstractFactory.Models.Enums;

namespace AbstractFactory.Models
{
    public abstract class Produto
    {
        public decimal Preco { get; set; }
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public TipoProduto Tipo { get; set; }

        public Produto(decimal preco, int identificador, string nome, TipoProduto tipo)
        {
            Preco = preco;
            Identificador = identificador;
            Nome = nome;
            Tipo = tipo;
        }
    }
}
