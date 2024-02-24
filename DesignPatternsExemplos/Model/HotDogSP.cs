using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Model
{
    //ConcreteProduct
    public class HotDogSP : HotDog
    {
        public HotDogSP()
        {
            ingredientes.Add("4 Salsichas Hot Dog Seara");
            ingredientes.Add("Manteiga com sal");
            ingredientes.Add("Mostarda amarela a gosto");
            ingredientes.Add("purê de batata");
            ingredientes.Add("Pão de hot dog");
            ingredientes.Add("molho");
        }
    }
}
