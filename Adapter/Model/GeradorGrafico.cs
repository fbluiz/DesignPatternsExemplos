using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Model
{
    public class GeradorGrafico : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }
        public List<string> YValores { get; set; }
        public List<int> yValores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GerarGraficos(string titulo, List<string> x , List<int> y )
        {
            //logica para gerar grafico
            Console.WriteLine( "GeradorGrafico: Gerando Grafico");    
        }
    }
}
