using System;

namespace math
{
public class operations
{
    public static void Main(string[] args)
    {
		//getting 2 values from user
        Console.WriteLine("Enter the greater value :");
        int first = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the smaller value :");
        int second = Convert.ToInt32(Console.ReadLine());
		
		//passing them in respective function
		int result_add = Add(first,second);
		int result_sub = Sub(first,second);
		int result_multiply = Mul(first,second);
		int result_div = Div(first,second);
		
		//printing values
		Console.WriteLine("The addition value of {0} and {1} is {2}",first,second,result_add);
		Console.WriteLine("The subtraction value of {0} and {1} is {2}",first,second,result_sub);
		Console.WriteLine("The division value of {0} and {1} is {2}",first,second,result_div);
		Console.WriteLine("The multiplication value of {0} and {1} is {2}",first,second,result_multiply);
    }

    static int Add(int num1, int num2)
    {
        int r_add = num1 + num2;
        return r_add;
    }
    static int Sub(int num1, int num2)
    {
        int r_sub = num1 - num2;
        return r_sub;
    }

    static int Mul(int num1, int num2)
    {
        int r_mul = num1 * num2;
        return r_mul;
    }
    static int Div(int num1, int num2)
    {
        int r_div = num1 / num2;
        return r_div;
    }


}
}