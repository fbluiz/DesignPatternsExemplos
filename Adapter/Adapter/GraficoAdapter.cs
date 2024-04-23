using Adapter.Interfaces;
using Adapter.Model;

namespace Adapter.Adapter
{
    public class GraficoAdapter : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }
        public List<int> yValores { get ; set; }

        public void GerarGraficos(string titulo, List<string> xValores, List<int> yValores)
        {
            SuperGeradorGrafico grafico = new();

            grafico.DesenharGrafico(titulo, xValores, yValores);
        }
    }
}
