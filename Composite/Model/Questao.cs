using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model
{
    public class Questao : ItemQuestionario
    {
        public Questao(string descricao) : base(descricao)
        {
        }

        public override void Exibir()
        {
            Console.WriteLine("Questão: " + Descricao);
        }
    }
}
