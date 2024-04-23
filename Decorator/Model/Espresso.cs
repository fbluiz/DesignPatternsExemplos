using Decorator.Interface;

namespace Decorator.Model
{
    public class Espresso : ICafe
    {
        public string Descricao()
        {
            return "Café Expresso";
        }

        public decimal Preco()
        {
            return 5.00M;
        }
    }
}
