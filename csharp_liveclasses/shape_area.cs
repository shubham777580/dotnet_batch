using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace shape_area
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

        Console.WriteLine("Area of square is : " + shape_area.square.sq_area(side_of_square));
        Console.WriteLine("Area of rectangle is : " + shape_area.rectangle.rect_area(len_of_rect, width_of_rect));



        
    }
}

class square
{
public static int sq_area(int side_sqaure)
{
    return side_sqaure * side_sqaure;
}
}

class rectangle
{
public static int rect_area(int len_rect, int width_rect)
{
    return len_rect* width_rect;
}
}

}