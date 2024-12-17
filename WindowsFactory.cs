using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }

    public class WindowsButton : IButton
    {
        public void Paint() => Console.WriteLine("Windows Button");
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Windows Checkbox");
    }

}
