﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Log: {message}");
        }
    }

}
