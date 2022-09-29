using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

public class Solution {
    public static void Main (string[] args)
    {

    
		int[] nums = {2,7,11,15};
		int target = 9;
        List<int> result = new List<int>();
		int a = 0;
        
       foreach (int i in nums)
       {
           foreach (int j in nums)
           {
			   a = i+j;
              //Console.WriteLine(String.Format("The value of i is {0} and value of j is {1}",i,j));
			  if (a == target)
			  {
				  Console.WriteLine(String.Format("The value of i is {0} and value of j is {1}",i,j));

           }
       }
        Console.WriteLine(result);
        
    }
	}
}