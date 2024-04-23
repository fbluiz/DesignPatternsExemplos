using Facade.Models;

namespace Facade.SubSistemas
{
    public class ServicoA
    {
        public static Livro GetLivro(string isbn)
        {
            var livro = new Livro();
            livro.ISBN = isbn;
            livro.Titulo = "Código Limpo";
            livro.Preco = 76;
            livro.Origem = "Mercado Livre";
            return livro;
        }
    }
}
