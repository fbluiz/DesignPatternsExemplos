namespace Singleton_Teste
{
    public class Singleton
    {
        private static Singleton instance;
        private int numeroDeInstancias = 0;
        private static object lockObject = new object();
        
        private Singleton() 
        {
            Console.WriteLine("Instanciando dentro do construtor privado");
            numeroDeInstancias++;
            Console.WriteLine($"Numero de instancias = {numeroDeInstancias}\n" );
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    //Para permite que o padrão singleton não seja violado em situações multi thread
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            Console.WriteLine("Criando a primeira intancia");
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
