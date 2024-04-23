namespace Composite.Model
{
    public abstract class ItemQuestionario
    {
        protected string Descricao { get; set; }

        public ItemQuestionario(string descricao)
        {
            Descricao = descricao;
        }

        public abstract void Exibir();
    }   
}
