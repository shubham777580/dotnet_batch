
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace swap_string_refrence
{
class Program 
{
    public static void Main (string[] args)
    {
        string a = "p";
        string b= "q";
        Ref(ref a, ref b);
        Console.WriteLine("a = "+a);
        Console.WriteLine("b = "+b);

        
    }

    public static void Ref (ref string i, ref string j)
    {
        i = "q";
        j = "p";


    }



}
}