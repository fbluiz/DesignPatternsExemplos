using Bridge.Models;
using Bridge.Services;

Funcionario funcionario1 = new()
{
    Id = 101,
    Nome = "Tila",
    SalarioBase = 3000,
    Incentivo = 200
};

Funcionario funcionario2 = new()
{
    Id = 102,
    Nome = "Zuca",
    SalarioBase = 4000,
    Incentivo = 300
};

CalculaSalario calcularJson = new(new GeraJson());
CalculaSalario calcularXML = new(new GeraXML());


calcularJson.ProcessaSalarioFunci(funcionario1);
calcularXML.ProcessaSalarioFunci(funcionario2);