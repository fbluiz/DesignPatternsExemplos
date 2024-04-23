using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Models
{
    public abstract class Arquivo
    {
        protected IGerarArquivo geraArquivo;
        public Arquivo(IGerarArquivo gerarArquivo)
        {
            this.geraArquivo = gerarArquivo;
        }

        public virtual void GravaArquivo (Funcionario funcionario)
        {
            geraArquivo.GerarArquivo(funcionario);
        }
    }
}
