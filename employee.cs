using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace employee
{


class Program 
{
    public static void Main (string[] args)
    {
        //taking inputs of employee details
        Console.WriteLine("Enter the employee 1 name : ");
        string emp1_name = Console.ReadLine();
        Console.WriteLine("Enter the employee 1 address : ");
        string emp1_add = Console.ReadLine();

        Console.WriteLine("Enter the employee 2 name : ");
        string emp2_name = Console.ReadLine();
        Console.WriteLine("Enter the employee 2 address : ");
        string emp2_add = Console.ReadLine();

        //sending data to employee class and cont function
        employee.employee_class.Cont(emp1_name,emp1_add,emp2_name,emp2_add);
        
    }
}

class employee_class
{
public static void Cont(string emp11_name, string emp11_add, string emp22_name, string emp22_add)
{
    //printing the recieved value
    Console.WriteLine("Employee 1 details are :     Name : " + emp11_name+ "      Address : "+ emp11_add);
    Console.WriteLine("Employee 2 details are :     Name : " + emp22_name+ "      Address : "+ emp22_add);


}

}


}