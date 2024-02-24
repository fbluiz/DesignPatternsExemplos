using AbstractFactory.Models;
using AbstractFactory.Models.Enums;

namespace AbstractFactory.Factory
{
    sealed class LivroFactory : ProdutoAbstractFactory
    {
        public override Produto CriarProduto(TipoProduto tipo)
        {
            var tipoLivro = (TipoLivro)tipo;

            switch (tipoLivro)
            {
                case TipoLivro.AudioBook:
                    return new Audiobook();
                case TipoLivro.Ebook:
                    return new Ebook();
                default: throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
