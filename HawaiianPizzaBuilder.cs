using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class HawaiianPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void BuildDough() => _pizza.Dough = "Soft";
        public void BuildSauce() => _pizza.Sauce = "Tomato";
        public void BuildTopping() => _pizza.Topping = "Ham & Pineapple";

        public Pizza GetResult() => _pizza;
    }

}
