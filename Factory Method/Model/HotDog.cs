using FactoryMethod.Model.Enums;
using System.Collections;
using System.Text;

namespace FactoryMethod.Model
{
    //product
    public abstract class HotDog
    {
        protected TipoHotDog Tipo { get; set; }
        protected ArrayList ingredientes = new();
        public string Preparar ()
        {
            StringBuilder descricao = new StringBuilder();

            descricao.AppendLine($"Preparando a hotdog :");
            descricao.AppendLine("Adicionando ingredientes:");

            foreach (var ingrediente in ingredientes)
            {
                descricao.AppendLine($"- {ingrediente}");
            }

            return descricao.ToString();
        }
    }
}
