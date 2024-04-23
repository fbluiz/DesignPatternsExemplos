using Facade.Facade;
using Facade.Models;

ComparaPreco comparaPreco= new();

Console.WriteLine("Informe o ISBN do Livro");
string isbn = Console.ReadLine();

List<Livro> Livros = comparaPreco.Comparar(isbn);

Console.WriteLine("Resultado da pesquisa");

Livros.ForEach(l => Console.WriteLine(l.Titulo + " " + "Preco: " + l.Preco + " " + "Origem: " + l.Origem));
