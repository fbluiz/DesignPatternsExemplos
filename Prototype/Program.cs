// Classe do produto que implementa ICloneable para suportar a cópia profunda
class Product : ICloneable
{
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }

    public Product(string name, List<string> ingredients)
    {
        Name = name;
        Ingredients = ingredients;
    }

    // Implementação do método Clone() para realizar a cópia profunda
    public object Clone()
    {
        // Clonando a lista de ingredientes
        List<string> clonedIngredients = new List<string>(Ingredients.Count);
        foreach (var ingredient in Ingredients)
        {
            clonedIngredients.Add(ingredient);
        }

        // Criando uma nova instância do produto com os valores clonados
        return new Product(Name, clonedIngredients);
    }

    // Método para exibir os detalhes do produto
    public void DisplayDetails()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Produto original
        var originalProduct = new Product("Pizza", new List<string> { "Dough", "Tomato Sauce", "Cheese" });

        // Clonando o produto original
        var clonedProduct = (Product)originalProduct.Clone();

        // Modificando o produto clonado
        clonedProduct.Name = "Pasta";
        clonedProduct.Ingredients.Add("Pasta Sauce");

        // Exibindo os detalhes do produto original e clonado
        Console.WriteLine("Original Product:");
        originalProduct.DisplayDetails();
        Console.WriteLine("\nCloned Product:");
        clonedProduct.DisplayDetails();
    }
}
