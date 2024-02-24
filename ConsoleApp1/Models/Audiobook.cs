namespace AbstractFactory.Models
{
    sealed class Audiobook : Livro
    {
        public TimeSpan Duracao { get; set; }
        public Audiobook() : base(15, 3, "Ilha do medo", "Desconhecido", "Suspense")
        {
            Duracao = new TimeSpan(1,30,0);
        }
    }
}
