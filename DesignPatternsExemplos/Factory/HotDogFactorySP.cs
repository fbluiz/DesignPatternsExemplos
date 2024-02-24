using FactoryMethod.Model;
using FactoryMethod.Model.Enums;
namespace FactoryMethod.Factory
{
    //ConcreteCreator
    public class HotDogFactorySP : HotDogFactory
    {
        protected override HotDog CriarHotdog(TipoHotDog tipo)
        {
            switch (tipo)
            {
                case TipoHotDog.tradicional:
                    return new HotDogSP();
                case TipoHotDog.gratinado:
                    return new HotDogGratinadoSP();
                default:
                    throw new ArgumentException($"Tipo de hot dog desconhecido: {tipo}");
            }
        }
    }
}
