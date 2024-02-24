using AbstractFactory.Models.Enums;

namespace AbstractFactory.Models
{
    public abstract class Livro : Produto
    {
        public string Autor { get; set; }
        public string Genero { get; set; }

        public Livro(decimal preco, int identificador, string nome, string autor, string genero) : base(preco, identificador, nome,TipoProduto.Livro)
        {
            Autor = autor;
            Genero = genero;    
        }
    }
}