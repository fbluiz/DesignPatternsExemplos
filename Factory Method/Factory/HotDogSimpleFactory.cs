namespace FactoryMethod.Factory
{
    public class HotDogSimpleFactory
    {
        public static HotDogFactory CriarFabricaDeHotDog(string estado)
        {
            switch (estado)
            {
                case "SP":
                    return new HotDogFactorySP();
                case "RJ":
                    return new HotDogFactoryRJ();
                default:
                    throw new ArgumentException($"Não temos hotdog caracteristico do estado: {estado}");
            }
        }
    }
}

