using Facade.Models;
using Facade.SubSistemas;

namespace Facade.Facade
{
    public class ComparaPreco
    {
        public List<Livro> Comparar(string isbn)
        {
            ServicoAClient clientA = new();
            var livroA = clientA.PesquisaLivro(isbn);

            ServicoBClient clientB = new();
            var LivroB = clientB.PesquisaLivro(isbn);

            var livros = new List<Livro>() { livroA, LivroB };
            livros.OrderByDescending(l => l.Preco);
            return livros;
        }
    }
}
