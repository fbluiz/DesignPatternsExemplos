using FactoryMethod.Factory;
using FactoryMethod.Model.Enums;

Console.WriteLine("==== HotDog ====");
Console.WriteLine("Informe o estado: São Paulo (SP) ou Rio de Janeiro (RJ)");
var estadoEscolhido = Console.ReadLine();

Console.WriteLine("Escolha o hotdog Tradicional ou Gratinado");
var tipoEscolhido = Console.ReadLine();
TipoHotDog tipoHotDog;

if (!Enum.TryParse(tipoEscolhido, ignoreCase: true, out tipoHotDog))
{
    Console.WriteLine("Opção inválida.");
}

try
{
    HotDogFactory hotdogFatory = HotDogSimpleFactory.CriarFabricaDePizza(estadoEscolhido);

    var hotdog = hotdogFatory.MontarHotgog(tipoHotDog);

    Console.WriteLine(hotdog.Preparar());
}

catch(Exception ex)
{
    Console.WriteLine("Erro: " + ex.ToString());   
}