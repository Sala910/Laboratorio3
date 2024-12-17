using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }

    public class MacButton : IButton
    {
        public void Paint() => Console.WriteLine("Mac Button");
    }

    public class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Mac Checkbox");
    }

}
