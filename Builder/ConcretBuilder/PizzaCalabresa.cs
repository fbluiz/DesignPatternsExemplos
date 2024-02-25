using Builder.Builder;
using Builder.Product;

namespace Builder.ConcretBuilder
{
    public sealed class PizzaCalabresa : PizzaBuilder
    {
        public override void IncluiIngredientes()
        {
            pizza.TipoMassa = TipoMassa.Grossa;
            pizza.TipoBorda = TipoBorda.Normal;
            pizza.Tamanho = Tamanho.Grande;
        }

        public override void PreparaMassa()
        {
            pizza.Ingredientes = new List<string> { "Calabreza em fatias",
                "Molho de tomate" };
        }
    }
}
