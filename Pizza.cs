﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public override string ToString()
        {
            return $"Pizza with {Dough} dough, {Sauce} sauce, {Topping} topping.";
        }
    }

}
