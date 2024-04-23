using Decorator.Decorator;
using Decorator.Interface;
using Decorator.Model;

var bebidas = new List<ICafe>();

//Café Filtrado com Chocolate
bebidas.Add(new ChocolateDecorator(new Filtrado()));

//Café Filtrado com Leite
bebidas.Add(new LeiteDecorator(new Filtrado()));

//Café espresso com leite e chocolate
bebidas.Add(new ChocolateDecorator(new LeiteDecorator(new Espresso())));


bebidas.ForEach(b => Console.WriteLine(b.Descricao() + " " + b.Preco()));