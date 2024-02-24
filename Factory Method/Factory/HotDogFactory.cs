using FactoryMethod.Model;
using FactoryMethod.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    //Creator
    public abstract class HotDogFactory
    {
        public HotDog MontarHotgog(TipoHotDog tipo)
        {
            HotDog hotdog;
            hotdog = CriarHotdog(tipo);
            return hotdog;
        }

        protected abstract HotDog CriarHotdog(TipoHotDog tipo);
    }
}
