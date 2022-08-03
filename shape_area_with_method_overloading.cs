using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace method_overloading
{
class Program 
{
    public static void Main (string[] args)
    {
        Console.WriteLine("Enter the side of sqaure : ");
        int side_of_square = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the length of rectangle: ");
        int len_of_rect = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the width of rectangle: ");
        int width_of_rect = Convert.ToInt32(Console.ReadLine());

        Program obj = new Program();
        obj.area(side_of_square);
        obj.area(len_of_rect, width_of_rect);
    }

        
        

    public static void area(int side_sqaure)
    {
         Console.WriteLine("Area of square is : " + side_sqaure * side_sqaure);
    }

        public static void area(int len_rect, int width_rect)
    {
         Console.WriteLine("Area of rectangle is : " + len_rect * width_rect);
    }




        
    }
}
