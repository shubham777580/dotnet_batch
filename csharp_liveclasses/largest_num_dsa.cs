
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace largest_num_dsa
{
class Program 
{
    public static void Main (string[] args)
    {
        int[] array1 = {10, 20, 30, 40,50,60,70,80,100,90};
        Array.Sort(array1);
        largest_num_dsa.Array_class.biggest_number_array(array1);


        largest_num_dsa.Arraylist_class.biggest_number_arraylist();

        largest_num_dsa.linkedlist_class.biggest_number_linkedlist();
        
    }
}

public static class Array_class
{
    public static void biggest_number_array(int[] arr1)
    {

        int big = 0;
        foreach(int i in arr1)
        {
            if(i > big)
            {
                big = i;
            }

        }
        Console.WriteLine("The biggest value in array is : "+big);

    }

}

public static class Arraylist_class 
{
    public static void biggest_number_arraylist()
    {
        var arraylist1 = new ArrayList() {10, 20, 30, 40,50,60,70,80,100,90};
        arraylist1.Sort();
        int big = 0;
        foreach(int i in arraylist1)
        {
            if(i > big)
            {
                big = i;
            }

        }
        Console.WriteLine("The biggest value in arraylist is : "+big);
    }

}

public static class linkedlist_class 
{
    public static void biggest_number_linkedlist()
    {
        LinkedList<int> list1 = new LinkedList<int>();
        list1.AddLast(10);
        list1.AddLast(20);
        list1.AddLast(30);
        list1.AddLast(40);
        Console.WriteLine("The biggest value in Linked list is : "+list1.Max());
        
    }

}
}