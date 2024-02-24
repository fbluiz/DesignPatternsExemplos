using AbstractFactory.Models;
using AbstractFactory.Models.Enums;

namespace AbstractFactory.Factory
{
    sealed class AlimentoFactory : ProdutoAbstractFactory
    {
        public override Produto CriarProduto(TipoProduto tipo)
        {
            var tipoAlimento = (TipoAlimento) tipo;

            switch (tipoAlimento) 
            {
                case TipoAlimento.BoloDePote:
                    return new BoloDePote();
                case TipoAlimento.BebidoAlcoolica:
                    return new BebidaAlcoolica();
                default: throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
