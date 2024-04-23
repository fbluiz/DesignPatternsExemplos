namespace Proxy_Solucao
{
    //RealSubject
    public class RealInternet : Internet
    {
        public override void Conexao(string host)
        {
            Console.WriteLine($"Conectando-se com o servidor : {host}\n");
        }
    }
}
