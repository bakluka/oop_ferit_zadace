﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDZ3
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string to_print)
        {
            Console.WriteLine(to_print);   //big no-no po predavanjima iz AV-a, ali zadatak je naizgled tako formatiran
        }
    }
}
