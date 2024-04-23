using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Model
{
    public sealed class SuperGeradorGrafico
    {
        public void init() { }
        public void DesenharGrafico(string titulo, List<string> x, List<int> y)
        {
            //logica para gerar graficos
            Console.WriteLine("SuperGeradorGrafico: Gerando Graficos aprimorados");
        }
    }
}
