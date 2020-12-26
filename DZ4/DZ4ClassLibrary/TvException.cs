using System;
namespace DZ4ClassLibrary
{
    public class TvException : Exception
    {
        public string Title{
            get;
            private set;
        }
        public TvException(string message, string title) : base(message)
        {
            Title = title;
        }
    }
}
