using System;  
using System.IO; 
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace teacher_data_manage
{
public class Driver
{
    public static void Main(string[] args)
    {
        

        //Updating and storing the values from text files
        LinkedList<string> list1 = new LinkedList<string>();
        string[] lines = File.ReadAllLines(@"C:\Users\shubham.mukherjee\Documents\GitHub\dotnet_batch\Assesments\assesment_1\teacher_data_textFile.txt");  
        foreach (string line in lines)  
        list1.AddLast(line);

        loop_start:
        //for the menu to continue from its start after each operation

        //Displaying headline
        Console.ForegroundColor = ConsoleColor.White;  
        Console.BackgroundColor = ConsoleColor.Red; 
        Console.WriteLine("Welcome to Simplilearn assesment 1 : teacher database (Author : Shubham Mukherjee)");
        Console.ResetColor();  

        //displaying menu of operations
        Menu_details_function();

        //getting int value for switch case
        int menu_select_int = Convert.ToInt32(Console.ReadLine());

        //switch case to run respective functions depending on int input
        switch (menu_select_int) 
        {
           case 1:
              Console.WriteLine("Option selected to view data");
              view_data_function(list1);
              break;
           case 2:
              Console.WriteLine("Option selected to delete data");
              list1 = delete_data_function(list1);
               break;
            case 3:
              Console.WriteLine("Option selected to insert data");
              list1 = insert_data_function(list1);
               break;

            case 4:
              Console.WriteLine("Option selected to save of all work done till now in a original text file ");
              update_data_function(list1);
               break;
            
           default:
              Console.WriteLine("No perfect option selected. Please select option from the given menu.");
              Menu_details_function();
               break;
        }

        goto loop_start;
        //to jump back to the start of the loop after 1 operation


        //to keep console awaiting
        Console.ReadKey();
        Console.ResetColor(); 


    }

    static void Menu_details_function(){

        //Menu details are written here
        Console.WriteLine("Press 1 to view data");
        Console.WriteLine("Press 2 to delete data");
        Console.WriteLine("Press 3 to insert data");
        Console.WriteLine("Press 4 to save of all work done till now in a original text file");
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine("Please note to save your work AFTER EVERY OPERATION from using option 4 or else work done will not be reflected");
        Console.ResetColor();  

        }

    static void view_data_function(LinkedList<string> view_list1){
        

        //printing the current data recieved from the list
        foreach (string view in view_list1)  
        Console.WriteLine(view);
        
    }

    static LinkedList<string> delete_data_function(LinkedList<string> delete_list1){
        
        //getting the input of teacher id to be deleted
        Console.WriteLine("Enter the teacher id to delete : ");
        string delete_teacher_id = Console.ReadLine();

        //getting new linked list ready for operations
        LinkedList<string> list12 = new LinkedList<string>();


        //getting string ready for searching and deletion
        delete_teacher_id = "Teacher ID : " + delete_teacher_id;

        foreach (string delete_line in delete_list1)
        {
            if(delete_line.Contains(delete_teacher_id))
            {
               continue;
               //not adding the deleted part in new list
            }
            else
            {
                list12.AddLast(delete_line);
                // adding rest of the parts in new list
            }

        }
        Console.WriteLine("Item deleted");
        Console.WriteLine("New updated list");

        //printing the new list

        foreach(string i in list12)
        Console.WriteLine(i);

        
        return list12;
        
    }

    static LinkedList<string> insert_data_function(LinkedList<string> insert_list1){
        
        //getting the input to be inserted
        Console.WriteLine("Enter the teacher id to insert : ");
        string insert_teacher_id = Console.ReadLine();

        Console.WriteLine("Enter the teacher name to insert : ");
        string insert_teacher_name = Console.ReadLine();

        Console.WriteLine("Enter the teacher class to insert : ");
        string insert_teacher_class = Console.ReadLine();

        //getting string ready for searching and insertion
        string insert_teacher_row = "Teacher ID : " + insert_teacher_id +", "+ "Name : " + insert_teacher_name +", "+ "Class : " + insert_teacher_class;

        //adding it to the main list
        insert_list1.AddLast(insert_teacher_row);

        Console.WriteLine("Item inserted");
        Console.WriteLine("New updated list");

        //printing the new list
        foreach(string i in insert_list1)
        Console.WriteLine(i);


        return insert_list1;
        
    }


    static void update_data_function(LinkedList<string> update_list1){
        //path of file
            string pathToFile = @"C:\Users\shubham.mukherjee\Documents\GitHub\dotnet_batch\Assesments\assesment_1\teacher_data_textFile.txt";
            TextWriter writer = new StreamWriter(pathToFile);

            Console.WriteLine("Flushing old values and adding fresh data.....");
                
                //to empty the pervious data
                writer.Flush();

                //to add new data in copy file
                foreach(string i in update_list1)
                writer.WriteLine(i);

            writer.Close();
            //to close and reflect the changes made

            Console.WriteLine("!!! DATA SAVED SUCCESSFULLY !!!!");

        
    }



}


}