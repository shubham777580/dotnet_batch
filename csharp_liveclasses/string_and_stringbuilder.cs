using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace string_example1
{
class Program 
{
    public static void Main (string[] args)
    {
        //getting input
        Console.WriteLine("Enter the first string : ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string : ");
        string str2 = Console.ReadLine();

        //running the functions of the other class
        Console.WriteLine("The string concatenation output is : " + string_example1.String_concatenate.Con(str1, str2));
        Console.WriteLine("The string builder output is : " + string_example1.String_Builder.Build(str1, str2));


    }
}

public class String_concatenate
{
    public static string Con(string s1, string s2)
    {
        string s3 = "";
        string space = " ";
        s3 = s1 + space + s2;
        return s3;
    }
}

public class String_Builder
{
    public static string Build(string s1, string s2)
    {
        StringBuilder str = new StringBuilder();
        string a = "";
        string space = " ";
        str.Append(s1);
        str.Append(space);
        str.Append(s2);
        a = str.ToString();
        return a;
    }
        
}
}