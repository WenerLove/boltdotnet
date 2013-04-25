﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloBolt.NET
{
    internal sealed class Application
    {
        internal void WriteLine(string str)
        {
            Console.WriteLine(str);
        }

        internal void Write(string str)
        {
            Console.Write(str);
        }

        internal void Quit()
        {
            Environment.Exit(0);
        }
    }
}
