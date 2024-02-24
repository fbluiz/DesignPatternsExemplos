using FactoryMethod.Model;
using FactoryMethod.Model.Enums;

namespace FactoryMethod.Factory
{
    //ConcreteCreator
    public class HotDogFactoryRJ : HotDogFactory
    {
        protected override HotDog CriarHotdog(TipoHotDog tipo)
        {
            switch (tipo)
            {
                case TipoHotDog.tradicional:
                    return new HotDogRJ();
                case TipoHotDog.gratinado:
                    return new HotDogGratinadoRJ();
                default:
                    throw new ArgumentException($"Tipo de hot dog desconhecido: {tipo}");
            }
        }
    }
}
