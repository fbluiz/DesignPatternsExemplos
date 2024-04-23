using Decorator.Interface;

namespace Decorator.Model
{
    public class Filtrado : ICafe
    {
        public string Descricao()
        {
            return "Café Filtrado";
        }

        public decimal Preco()
        {
            return 4.00M;
        }
    }
}
