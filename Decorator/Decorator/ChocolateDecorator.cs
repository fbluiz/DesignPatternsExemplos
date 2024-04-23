using Decorator.Interface;

namespace Decorator.Decorator
{
    public class ChocolateDecorator : OpcionalDecorator
    {
        public ChocolateDecorator(ICafe cafe) : base(cafe)
        {
            _opcional = " mais chocolate";
            _preco = 3.00M;
        }
    }
}
