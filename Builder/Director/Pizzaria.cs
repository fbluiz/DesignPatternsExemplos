using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class Pizzaria
    {
        private readonly PizzaBuilder builder;
        public Pizzaria(PizzaBuilder builder)
        {
            this.builder = builder;
        }
        //Construct
        public void MontaPizza()
        {
            builder.CriaPizza();
            builder.PreparaMassa();
            builder.IncluiIngredientes();
        }
        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}
