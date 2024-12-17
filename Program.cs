using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Singleton ===");
            var singleton = Singleton.Instance;
            singleton.SomeMethod();

            Console.WriteLine("\n=== Factory Method ===");
            LoggerFactory fileFactory = new FileLoggerFactory();
            ILogger fileLogger = fileFactory.CreateLogger();
            fileLogger.Log("File log example.");

            LoggerFactory consoleFactory = new ConsoleLoggerFactory();
            ILogger consoleLogger = consoleFactory.CreateLogger();
            consoleLogger.Log("Console log example.");

            Console.WriteLine("\n=== Abstract Factory ===");
            IGUIFactory windowsFactory = new WindowsFactory();
            Application windowsApp = new Application(windowsFactory);
            windowsApp.Paint();

            IGUIFactory macFactory = new MacFactory();
            Application macApp = new Application(macFactory);
            macApp.Paint();

            Console.WriteLine("\n=== Builder ===");
            IPizzaBuilder builder = new HawaiianPizzaBuilder();
            PizzaDirector director = new PizzaDirector();
            director.Construct(builder);
            Pizza pizza = builder.GetResult();
            Console.WriteLine(pizza);
        }
    }

}

