using Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Factory
{
    //FlyweightFactory
    public class ImagemFactory
    {
        private static Dictionary<string, ImagemBase> imagens = new();

        public ImagemBase GetImagem(string nomeArquivo)
        {
            ImagemBase imagem = null;
            
            if(imagens.ContainsKey(nomeArquivo)) 
            {
                imagem = imagens[nomeArquivo];
                Console.WriteLine($">>> Retornando imagem em cache : {nomeArquivo} >>>");
            }
            else
            {
                //criar uma nova imagem e incluir o cache
                imagem = new Imagem(nomeArquivo);
                imagens.Add(nomeArquivo, imagem);
                Console.WriteLine($"### Instanciando uma nova imagem : {nomeArquivo} ###");
            }
            return imagem;
        }

    }
}
