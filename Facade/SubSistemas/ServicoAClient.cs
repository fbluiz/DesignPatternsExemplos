using Facade.Models;

namespace Facade.SubSistemas
{
    public class ServicoAClient
    {
        public Livro PesquisaLivro(string isbn)
        {
            return ServicoA.GetLivro(isbn);
        }
    }
}
