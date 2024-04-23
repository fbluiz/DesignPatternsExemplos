using Bridge.Interfaces;
using Bridge.Models;

namespace Bridge.Services
{
    public class CalculaSalario : Arquivo
    {
        public CalculaSalario(IGerarArquivo gerarArquivo) : base(gerarArquivo) { }

        public void ProcessaSalarioFunci(Funcionario funci)
        {
            funci.SalarioTotal = funci.SalarioBase + funci.Incentivo;
            Console.WriteLine("Valor do salário para o funcionário: " + funci.Nome);
            Console.WriteLine($"Salario total: {funci.SalarioTotal}");

            geraArquivo.GerarArquivo(funci);
        }
    }
}
