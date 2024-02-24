using AbstractFactory.Factory;
using AbstractFactory.Models;
using AbstractFactory.Models.Enums;
using System.Reflection;

var produtos = new List<Produto>();

//Obter as fábricas 
var alimentoFactory = ProdutoAbstractFactory.CriaFabricaProdutos(TipoProduto.Alimento);
var livroFactory  = ProdutoAbstractFactory.CriaFabricaProdutos(TipoProduto.Livro);

//Criar os objetos com base no tipo do livro
produtos.Add(livroFactory.CriarProduto((TipoProduto) TipoLivro.Ebook));
produtos.Add(livroFactory.CriarProduto((TipoProduto)TipoLivro.AudioBook));

//Criar os objetos com base no tipo do alimento
produtos.Add(alimentoFactory.CriarProduto((TipoProduto)TipoAlimento.BoloDePote));
produtos.Add(alimentoFactory.CriarProduto((TipoProduto)TipoAlimento.BebidoAlcoolica));

//Exibir detalhes
produtos.ForEach(p => ExibeDetalhes(p));


static void ExibeDetalhes(Produto produto)
{
    Console.WriteLine("Detalhes do Produto:");

    Type type = produto.GetType();
    PropertyInfo[] properties = type.GetProperties();

    foreach (PropertyInfo property in properties)
    {
        object value = property.GetValue(produto);
        Console.WriteLine($"{property.Name}: {value}");
    }
}