using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class PizzaDirector
    {
        public void Construct(IPizzaBuilder builder)
        {
            builder.BuildDough();
            builder.BuildSauce();
            builder.BuildTopping();
        }
    }

}
