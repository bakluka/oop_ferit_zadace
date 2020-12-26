using System;
using DZ4ClassLibrary.Properties;
namespace DZ4ClassLibrary
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string to_print)
        {
            Console.WriteLine(to_print);   //big no-no po predavanjima iz AV-a, ali zadatak je naizgled tako formatiran
        }
    }
}
