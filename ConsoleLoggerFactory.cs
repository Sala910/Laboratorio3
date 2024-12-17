using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class ConsoleLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }

}
