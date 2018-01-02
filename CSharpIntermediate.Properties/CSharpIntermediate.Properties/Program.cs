using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1978, 1, 1));
            Console.WriteLine(person.Age);
        }
    }
}
