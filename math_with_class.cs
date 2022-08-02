using System;

namespace math_with_class
{
public class Driver
{
    public static void Main(string[] args)
    {
		//getting 2 values from user
        Console.WriteLine("Enter the greater value :");
        int first = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the smaller value :");
        int second = Convert.ToInt32(Console.ReadLine());
		

		
		//printing values
		Console.WriteLine("The addition value is : " + math_with_class.Add_class.Add(first, second));
		Console.WriteLine("The subtraction value is : " + math_with_class.Sub_class.Sub(first, second));
		Console.WriteLine("The division value is :"+ math_with_class.Division_class.Div(first, second));
		Console.WriteLine("The multiplication value is :" + math_with_class.Multiply_class.Mul(first, second));
    }


}

class Sub_class
{
    public static int Sub(int num1, int num2)
    {

        return num1 - num2;
    }
}

class Multiply_class
{
    public static int Mul(int num1, int num2)
    {
        return num1 * num2;
    }
}

 class Division_class
{
    public static int Div(int num1, int num2)
    {

        return num1 / num2;
    }
}

class Add_class
{
   public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

}