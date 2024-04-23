using Bridge.Interfaces;
using Bridge.Models;

namespace Bridge.Services
{
    public class GeraJson : IGerarArquivo
    {
        public void GerarArquivo(Funcionario funci)
        {
            //logica pra gerar os dados no formato JSON

            Console.WriteLine("Dados do funcionario " + funci.Nome + "Gerados no formato JSON");
        }
    }
}
