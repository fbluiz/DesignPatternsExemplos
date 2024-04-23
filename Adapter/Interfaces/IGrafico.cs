namespace Adapter.Interfaces
{
    public interface IGrafico
    {
        string Titulo { get; set; }
        List<string> XValores { get; set; }
        List<int> yValores { get; set; }
        void GerarGraficos(string titulo,List<string> xValores, List<int> yValores);
    }
}
