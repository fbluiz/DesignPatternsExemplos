namespace AbstractFactory.Models
{
    sealed class Ebook : Livro
    {
        public string TipoArquivo { get; set; }

        public Ebook() : base(30, 4, "Os Mercenários", "Desconhecido", "Ação")
        {
            TipoArquivo = "PDF";
        }
    }
}
