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

        //area_class obj = new area();

        int square_area_variable = method_overloading.area_class.area(side_of_square);
        Console.WriteLine("Area of square is : " + square_area_variable );

        int rectangle_area_variable = method_overloading.area_class.area(len_of_rect, width_of_rect);
         Console.WriteLine("Area of rectangle is : " +rectangle_area_variable);
    }
}

        
        public static class area_class
        {

        

    public static int area(int side_sqaure)
    {
         return side_sqaure * side_sqaure;
    }

        public static int area(int len_rect, int width_rect)
    {
        return len_rect * width_rect;
    }




        
    }
}
