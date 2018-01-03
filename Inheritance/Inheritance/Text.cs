using System;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int Fontsize { get; set; }
        public string Fontname { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }

    }
}