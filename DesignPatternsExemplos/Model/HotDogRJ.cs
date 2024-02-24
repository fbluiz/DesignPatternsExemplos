namespace FactoryMethod.Model
{
    //ConcreteProduct
    public class HotDogRJ : HotDog
    {
        public HotDogRJ()
        {
            ingredientes.Add("pão francês");
            ingredientes.Add("4 Salsichas Hot Dog Seara");
            ingredientes.Add("ovo de codorna");
            ingredientes.Add("molho vinagrete");
            ingredientes.Add("queijo parmesão");
            ingredientes.Add("batata-palha");
        }
    }
}
