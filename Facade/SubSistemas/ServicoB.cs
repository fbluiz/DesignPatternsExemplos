using Facade.Models;

namespace Facade.SubSistemas
{
    public class ServicoB
    {
        public static Livro GetLivro(string isbn)
        {
            var livro = new Livro();
            livro.ISBN = isbn;
            livro.Titulo = "Código Limpo";
            livro.Preco = 73;
            livro.Origem = "Amazon";
            return livro;
        }
    }
}
