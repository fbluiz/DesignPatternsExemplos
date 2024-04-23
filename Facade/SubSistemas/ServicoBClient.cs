using Facade.Models;

namespace Facade.SubSistemas
{
    public class ServicoBClient
    {
        public Livro PesquisaLivro (string isbn)
        {
            return ServicoB.GetLivro(isbn); 
        }
    }
}
