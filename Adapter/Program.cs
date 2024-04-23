using Adapter.Adapter;
using Adapter.Interfaces;
using Adapter.Model;

//var grafico = new GeradorGrafico();

IGrafico grafico = new GraficoAdapter();

grafico.Titulo = "Gerador de Graficos";

List<string> xValores = new();
xValores.Add("seg");
xValores.Add("ter");

List<int> yValores = new();
yValores.Add(10);
yValores.Add(20);

grafico.GerarGraficos(grafico.Titulo,xValores,yValores);
Console.ReadKey();