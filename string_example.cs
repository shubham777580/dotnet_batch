using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace string_example
{
class Program 
{
    public static void Main (string[] args)
    {
        StringBuilder str = new StringBuilder("Word1");
        str.Append(",Word2");
        str.Append(",Word3");
        Console.WriteLine(str);
    }
}
}