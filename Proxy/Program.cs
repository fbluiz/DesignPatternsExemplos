
namespace Proxy_Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Informe a url do site : ");
                var url = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(url))
                {
                    try
                    {
                        var internet = new ProxyInternet();
                        internet.Conexao(url);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    flag = false;
                }
            }
            Console.WriteLine("Fim de processamento");
            Console.ReadKey();
        }
    }
}
