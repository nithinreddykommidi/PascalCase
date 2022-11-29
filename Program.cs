internal class Program
{

    static void Main1()
    {
        Console.WriteLine("hi");
    }
    private static void Datatypes()
    {

        // Comments in C#
        // single line comments - //

        /*
         * multiline comment
         */
        // To print output to the console

        Console.WriteLine("Hello, World!");

        // To read input from the user
        Console.WriteLine("Enter Your Name");
        string Name = Console.ReadLine();
        Console.WriteLine("Have a great day {0}", Name);

        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);

        /*
         * Data types
         * 1 Boolean
         * eg: bool Value = true
         * 2 Integers
         * To find the max and min range of integral datatypes
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);
         *  sbyte
         *  byte
         *  char
         *  short
         *  ushort
         *  int
         *  uint
         *  long
         *  ulong
         * 3 Floats
         *  float (7 digits precision)
         *  double (15 -16 digits precision)
         * 4 Decimal Types
         *  decimal
         * 5 String
         */


    }

    static void Strings()
    {
        string Name = "nithin";
        Console.WriteLine(Name);
        // To print name in double quots we can use escape character \
        Console.WriteLine("my name is \"{0}\"", Name);
        // \n for printing in new line 
        string Numbers = "one\ntwo\nthree";
        Console.WriteLine(Numbers);
        // Verbatim literal is used to take string as it is without any escape chars
        // it is represented by @
        string Path = @"C:\Program Files (x86)\Notepad++";
        Console.WriteLine(Path);
    }
    static void Operators()
    {
        /*
         * 1 Assignment Operator eg: = 
         *  Used to assign data to a variable
         * 2 Arithmetic Operators eg: + - * / % 
         * 3 Comparision Operators eg: ==, !=, >, >=, <, <=
         * 4 Conditional Operators eg: &&, ||
         * 5 Tenary Operators ?:
         * 6 Null Coalescing Operators ??
         */
    }
    static void Nullable()
    {
        // Value Types -> int,float,double,structs,enums,boll
        // reference Types -> Interface, Class, Delegates, Arrays 

        // Value types are not nullable

        // int i = null; will gives an error. To convert int into nullable we can use ?

        int? i = null;

        bool? AreYouMajor = null;
        if (AreYouMajor == true)
        {
            Console.WriteLine("user is Major");
        }
        else if (AreYouMajor == false)
        {
            Console.WriteLine("User is not major");
        }
        else
        {
            Console.WriteLine("User did not answer");
        }

        int? AvailableTickets = null;
        int NoOfTickets;

        if (AvailableTickets == null)
        {
            NoOfTickets = 0;
        }
        else
        {
            NoOfTickets = (int)AvailableTickets;
        }
        Console.WriteLine("Total Tickets Available are {0}", NoOfTickets);

        // Optimized with using Null Coalescing Operator
        int? AvailableTickets1 = 5;
        int NoOfTickets1 = AvailableTickets1 ?? 0;
        Console.WriteLine("Total Tickets Available are {0}", NoOfTickets1);



    }

    static void DatatypeConversion()
    {
        /* TypeCasting
         * Types of conversions
         * Implicit conversion
         *  No loss of data and no possibility of throwing exception
         * Explicit conversion
         * Parse() and TryParse()
         * used to parse the data from a variable
         * Parse() will throw Exception if there is no match where as TryPase() return Boolean value
         */

        // Implicit

        int i = 5;
        float f = i;
        Console.WriteLine("after implicit conversion {0}", f);

        // Explicit

        float fl = 123.45f;
        int num = (int)fl;
        Console.WriteLine("after explicit conversion {0}", num);

        // Parse()

        string strNumber = "100";
        int num1 = int.Parse(strNumber);
        Console.WriteLine("after parsing valid int {0}", num1);

        // TryParse()

        string strInvalidNum = "25";
        int age = 0;
        bool IsConcersionSuccessful = int.TryParse(strInvalidNum, out age);
        if (IsConcersionSuccessful)
        {
            Console.WriteLine("After TryParse() {0}", age);
        }
        else
        {
            Console.WriteLine("Conversion is not successful");
        }


    }

    static void Arrays()
    {
        // array can hold similar datatypes
        // creating array
        // Can't change the size of the array once it is created, there will be no error while assinging the value to array
        // but we will get Exception while runtime 
        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;
        Console.WriteLine(EvenNumbers[1]);
    }

    static void IfStatement()
    {
        Console.WriteLine("Enter a number b/w 1 to 3");
        int UserInput = int.Parse(Console.ReadLine());

        if (UserInput == 1)
        {
            Console.WriteLine("the input is one");
        }
        else if (UserInput == 2)
        {
            Console.WriteLine("the input is two");
        }
        else if (UserInput == 3)
        {
            Console.WriteLine("the input is three");
        }
        else
        {
            Console.WriteLine("the input is not b/w 1 and 3");
        }
        Console.WriteLine("Enter a number");


        int UserInput1 = int.Parse(Console.ReadLine());
        if (UserInput1 == 10 || UserInput1 == 20)
        {
            // the | or & will check both conditions
            // && and || will not check second condition if first condition is true or false 
            Console.WriteLine("the number is {0}", UserInput1);
        }
        else
        {
            Console.WriteLine("the number is not 10 or 20");
        }
    }
    static void SwitchStatement()
    {
        // Switch is used to replace multiple if else statements
        Console.WriteLine("Enter a number b/w 1 and 3");
        int num = int.Parse(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            default:
                Console.WriteLine("number is not b/w 1 and 3");
                break;

        }
        // Switch with multiple conditions 

        switch (num)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("the num is {0}", num);
                break;
            default:
                Console.WriteLine("number is not b/w 1 and 3");
                break;

        }
    }
    static void gotop()
    {
        int TotalCoffeeCost = 0;
    // start is called aS label
    start:
        Console.WriteLine("1 - small, 2 - medium, 3 - Large");
        int UserChoice = int.Parse(Console.ReadLine());
        switch (UserChoice)
        {
            case 1:
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Invalid Choice try again");
                break;
        }
    again:
        Console.WriteLine("want to continue shopping yes or no");
        string ContinueShopping = Console.ReadLine();
        ContinueShopping = ContinueShopping.ToUpper();
        switch (ContinueShopping)
        {
            case "YES":
                goto start;
            case "NO":
                break;
            default:
                goto again;


        }

        Console.WriteLine("Bill Ammount {0}", TotalCoffeeCost);
    }
    static void Whileloop()
    {
        /* while loop
        do while
        for 
        for each
        */
        Console.WriteLine("Enter the range");
        int Num = int.Parse(Console.ReadLine());
        int i = 0;
        while (i <= Num)
        {
            //Console.WriteLine(i);
            Console.Write(i + " "); // to write all value in single line with space
            i += 2;
        }
    }

    static void forloop()
    {
        int[] nums = new int[3];
        nums[0] = 1;
        nums[1] = 2;
        nums[2] = 3;

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }

        // for each loop

        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }

    }
    static void break_()
    { 
    

        // break and continue

        for(int i = 0; i <= 20;i++)
        {

            Console.WriteLine(i);
            if (i == 10)
                break;
        }

        
    }
    static void Continue_()
    {


        // break and continue

        for (int i = 0; i <= 20; i++)
        {

            
            if (i%2 == 1)
                continue;

            Console.WriteLine(i);
        }


    }

    // Creating Method with Params
    static void Method(int i, int j)
    {
        int k = i + j;
        Console.WriteLine(k);
    }

    /* To create method with return we should specify the return type while creating the method
    // eg : static int methname()
    static int ReturnType(int i, int j)
    {
        int k = i + j;
        return k;
    }
    // to call the function 
    static void Fun1()
    {
        Program e1 = new Program();
        int a = e1.ReturnType(1, 2);
        Console.WriteLine(a);
    }
    */

}   