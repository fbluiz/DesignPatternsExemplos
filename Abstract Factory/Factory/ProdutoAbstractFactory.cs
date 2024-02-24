using AbstractFactory.Models;
using AbstractFactory.Models.Enums;

namespace AbstractFactory.Factory
{
    public abstract class ProdutoAbstractFactory
    {
        public abstract Produto CriarProduto(TipoProduto tipo);

        public static ProdutoAbstractFactory CriaFabricaProdutos(TipoProduto tipo)
        {
            switch (tipo)
            {
                case TipoProduto.Alimento:
                    {
                        return new AlimentoFactory();
                    }

                case TipoProduto.Livro:
                    {
                        return new LivroFactory();
                    }

                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
                    }
            }
        }
    }
}