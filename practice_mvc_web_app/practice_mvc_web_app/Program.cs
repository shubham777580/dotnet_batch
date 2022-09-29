////var builder = WebApplication.CreateBuilder(args);

////// Add services to the container.
////builder.Services.AddControllersWithViews();

////var app = builder.Build();

////// Configure the HTTP request pipeline.
////if (!app.Environment.IsDevelopment())
////{
////    app.UseExceptionHandler("/Home/Error");
////    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
////    app.UseHsts();
////}

////app.UseHttpsRedirection();
////app.UseStaticFiles();

////app.UseRouting();

////app.UseAuthorization();

////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Home}/{action=Index}/{id?}");

////app.Run();


////using System;
////using System.IO;
////using System.Collections;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;

//    class Student
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int ID { get; set; }
//        public GradeLevel? Year { get; set; }
//        public List<int> ExamScores { get; set; }

//        public Student(string FirstName, string LastName, int ID, GradeLevel Year, List<int> ExamScores)
//        {
//            this.FirstName = FirstName;
//            this.LastName = LastName;
//            this.ID = ID;
//            this.Year = Year;
//            this.ExamScores = ExamScores;
//        }

//        public Student(string FirstName, string LastName, int StudentID, List<int>? ExamScores = null)
//        {
//            this.FirstName = FirstName;
//            this.LastName = LastName;
//            ID = StudentID;
//            this.ExamScores = ExamScores ?? Enumerable.Empty<int>().ToList();
//        }

//        public static List<Student> students = new()
//    {
//        new(
//            FirstName: "Terry", LastName: "Adams", ID: 120,
//            Year: GradeLevel.SecondYear,
//            ExamScores: new() { 99, 82, 81, 79 }
//        ),
//        new(
//            "Fadi", "Fakhouri", 116,
//            GradeLevel.ThirdYear,
//            new() { 99, 86, 90, 94 }
//        ),
//        new(
//            "Hanying", "Feng", 117,
//            GradeLevel.FirstYear,
//            new() { 93, 92, 80, 87 }
//        ),
//        new(
//            "Cesar", "Garcia", 114,
//            GradeLevel.FourthYear,
//            new() { 97, 89, 85, 82 }
//        ),
//        new(
//            "Debra", "Garcia", 115,
//            GradeLevel.ThirdYear,
//            new() { 35, 72, 91, 70 }
//        ),
//        new(
//            "Hugo", "Garcia", 118,
//            GradeLevel.SecondYear,
//            new() { 92, 90, 83, 78 }
//        ),
//        new(
//            "Sven", "Mortensen", 113,
//            GradeLevel.FirstYear,
//            new() { 88, 94, 65, 91 }
//        ),
//        new(
//            "Claire", "O'Donnell", 112,
//            GradeLevel.FourthYear,
//            new() { 75, 84, 91, 39 }
//        ),
//        new(
//            "Svetlana", "Omelchenko", 111,
//            GradeLevel.SecondYear,
//            new() { 97, 92, 81, 60 }
//        ),
//        new(
//            "Lance", "Tucker", 119,
//            GradeLevel.ThirdYear,
//            new() { 68, 79, 88, 92 }
//        ),
//        new(
//            "Michael", "Tucker", 122,
//            GradeLevel.FirstYear,
//            new() { 94, 92, 91, 91 }
//        ),
//        new(
//            "Eugene", "Zabokritski", 121,
//            GradeLevel.FourthYear,
//            new() { 96, 85, 91, 60 }
//        )};

//        static void Main(string[] args)
//        {
//            void QueryHighScores(int exam, int score)
//            {
//                var highScores =
//                    from student in students
//                    where student.ExamScores[exam] > score
//                    select new
//                    {
//                        Name = student.FirstName,
//                        Score = student.ExamScores[exam]
//                    };

//                foreach (var item in highScores)
//                {
//                    Console.WriteLine($"{item.Name,-15}{item.Score}");
//                }
//            }

//            QueryHighScores(1, 90);

//        // QueryMethod1 returns a query as its value.
//        IEnumerable<string> QueryMethod1(int[] ints) =>
//            from i in ints
//            where i > 4
//            select i.ToString();

//        // QueryMethod2 returns a query as the value of the out parameter returnQ
//        void QueryMethod2(int[] ints, out IEnumerable<string> returnQ) =>
//            returnQ =
//                from i in ints
//                where i < 4
//                select i.ToString();

//        int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//        // QueryMethod1 returns a query as the value of the method.
//        var myQuery1 = QueryMethod1(nums);

//        // Query myQuery1 is executed in the following foreach loop.
//        Console.WriteLine("Results of executing myQuery1:");
//        // Rest the mouse pointer over myQuery1 to see its type.
//        foreach (var s in myQuery1)
//        {
//            Console.WriteLine(s);
//        }

//        // You also can execute the query returned from QueryMethod1
//        // directly, without using myQuery1.
//        Console.WriteLine("\nResults of executing myQuery1 directly:");
//        // Rest the mouse pointer over the call to QueryMethod1 to see its
//        // return type.
//        foreach (var s in QueryMethod1(nums))
//        {
//            Console.WriteLine(s);
//        }

//        // QueryMethod2 returns a query as the value of its out parameter.
//        QueryMethod2(nums, out IEnumerable<string> myQuery2);

//        // Execute the returned query.
//        Console.WriteLine("\nResults of executing myQuery2:");
//        foreach (var s in myQuery2)
//        {
//            Console.WriteLine(s);
//        }

//        // You can modify a query by using query composition. In this case, the
//        // previous query object is used to create a new query object; this new object
//        // will return different results than the original query object.
//        myQuery1 =
//            from item in myQuery1
//            orderby item descending
//            select item;

//        // Execute the modified query.
//        Console.WriteLine("\nResults of executing modified myQuery1:");
//        foreach (var s in myQuery1)
//        {
//            Console.WriteLine(s);
//        }

//        List<int> numbers = new() { 1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

//        IEnumerable<int> queryFactorsOfFour =
//            from num in numbers
//            where num % 4 == 0
//            select num;

//        // Store the results in a new variable
//        // without executing a foreach loop.
//        List<int> factorsofFourList = queryFactorsOfFour.ToList();

//        // Read and write from the newly created list to demonstrate that it holds data.
//        Console.WriteLine(factorsofFourList[2]);
//        factorsofFourList[2] = 0;
//        Console.WriteLine(factorsofFourList[2]);

//        // Variable queryLastNames is an IEnumerable<IGrouping<string,
//        // DataClass.Student>>.
//        var groupByLastNamesQuery =
//            from student in students
//            group student by student.LastName into newGroup
//            orderby newGroup.Key
//            select newGroup;

//        foreach (var nameGroup in groupByLastNamesQuery)
//        {
//            Console.WriteLine($"Key: {nameGroup.Key}");
//            foreach (var student in nameGroup)
//            {
//                Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
//            }
//        }

//        /* Output:
//            Key: Adams
//                    Adams, Terry
//            Key: Fakhouri
//                    Fakhouri, Fadi
//            Key: Feng
//                    Feng, Hanying
//            Key: Garcia
//                    Garcia, Cesar
//                    Garcia, Debra
//                    Garcia, Hugo
//            Key: Mortensen
//                    Mortensen, Sven
//            Key: O'Donnell
//                    O'Donnell, Claire
//            Key: Omelchenko
//                    Omelchenko, Svetlana
//            Key: Tucker
//                    Tucker, Lance
//                    Tucker, Michael
//            Key: Zabokritski
//                    Zabokritski, Eugene
//        */





//        // Create a collection of person-pet pairs. Each element in the collection
//        // is an anonymous type containing both the person's name and their pet's name.
//        Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
//        Person terry = new("Terry", "Adams");
//        Person charlotte = new("Charlotte", "Weiss");
//        Person arlene = new("Arlene", "Huff");
//        Person rui = new("Rui", "Raposo");

//        List<Person> people = new() { magnus, terry, charlotte, arlene, rui };

//        List<Pet> pets = new()
//{
//    new(Name: "Barley", Owner: terry),
//    new("Boots", terry),
//    new("Whiskers", charlotte),
//    new("Blue Moon", rui),
//    new("Daisy", magnus),
//};

//        var query =
//            from person in people
//            join pet in pets on person equals pet.Owner
//            select new
//            {
//                OwnerName = person.FirstName,
//                PetName = pet.Name
//            };

//        foreach (var ownerAndPet in query)
//        {
//            Console.WriteLine($"\"{ownerAndPet.PetName}\" is owned by {ownerAndPet.OwnerName}");
//        }

//        /* Output:
//             "Daisy" is owned by Magnus
//             "Barley" is owned by Terry
//             "Boots" is owned by Terry
//             "Whiskers" is owned by Charlotte
//             "Blue Moon" is owned by Rui
//        */





//}





//}

//    enum GradeLevel
//    {
//        FirstYear = 1,
//        SecondYear,
//        ThirdYear,
//        FourthYear
//    };


class something
{
    record Person(string FirstName, string LastName);
    record Pet(string Name, Person Owner);
    record Employee(string FirstName, string LastName, int EmployeeID);
    record Cat(string Name, Person Owner) : Pet(Name, Owner);
    record Dog(string Name, Person Owner) : Pet(Name, Owner);
    public static void Main(string[] args)
    {
        Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
        Person terry = new("Terry", "Adams");
        Person charlotte = new("Charlotte", "Weiss");
        Person arlene = new("Arlene", "Huff");

        Pet barley = new("Barley", terry);
        Pet boots = new("Boots", terry);
        Pet whiskers = new("Whiskers", charlotte);
        Pet bluemoon = new("Blue Moon", terry);
        Pet daisy = new("Daisy", magnus);

        // Create two lists.
        List<Person> people = new() { magnus, terry, charlotte, arlene };
        List<Pet> pets = new() { barley, boots, whiskers, bluemoon, daisy };

        var query =
            from person in people
            join pet in pets on person equals pet.Owner into gj
            from subpet in gj.DefaultIfEmpty()
            select new
            {
                person.FirstName,
                PetName = subpet?.Name ?? string.Empty
            };

        foreach (var v in query)
        {
            Console.WriteLine($"{v.FirstName + ":",-15}{v.PetName}");
        }

        

    // This code produces the following output:
    //
    // Magnus:        Daisy
    // Terry:         Barley
    // Terry:         Boots
    // Terry:         Blue Moon
    // Charlotte:     Whiskers
    // Arlene:
}
   // record class Person(string FirstName, string LastName);
    //record class Pet(string Name, Person Owner);
}

