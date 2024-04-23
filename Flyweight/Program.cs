using Flyweight.Factory;

namespace Flyweight_Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ImagemFactory();

            for (int i = 0; i < 6; ++i)
            {
                var imagem = factory.GetImagem("minhaImagem.jpg");

                imagem.Exibir(getRandomPosicao(), getRandomPosicao(),
                              getRandomDimensao(), getRandomDimensao());
            }
            Console.ReadKey();

        }
        private static int getRandomPosicao()
        {
            Random rnd = new();
            return rnd.Next(0, 500);
        }
        private static int getRandomDimensao()
        {
            Random rnd = new();
            return rnd.Next(100, 500);
        }
    }
}
