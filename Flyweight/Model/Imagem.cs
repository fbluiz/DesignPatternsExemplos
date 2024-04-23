namespace Flyweight.Model
{
    public class Imagem : ImagemBase
    {
        //estado intriseco
        protected string _nomeArquivo;
        public Imagem(string nomeArquivo)
        {
            _nomeArquivo = nomeArquivo;
        }
        //estado extrinseco
        public override void Exibir(int x, int y, int largura, int altura)
        {
            Console.WriteLine(
             $"<img src= {_nomeArquivo} style=left:{x}px; top:{y}px; " +
             $"width:{largura}px; height:{altura}px;");
        }
    }
}
