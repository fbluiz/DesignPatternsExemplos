using Singleton_Teste;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Iniciando teste da implementação do padrão singleton");

        Parallel.Invoke(
            () => AcessoThread1(),
            () => AcessoThread2());
    }

    private static void AcessoThread1()
    {
        Console.WriteLine("Tentando criar a primeira instância");

        Singleton s1 = Singleton.Instance;

    }

    private static void AcessoThread2()
    {
        Console.WriteLine("Tentando criar a segunda instância");

        Singleton s2 = Singleton.Instance;

    }
}