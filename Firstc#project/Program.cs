
//string Fname = string.Empty;
//string Lname= string.Empty;
//int age = 18;
//decimal d = 2.2222M;
//DateTime dob = DateTime.Now;
////Console.WriteLine( " Your name is " +name + ". And your age is "+ age );
////Console.WriteLine( "Today is "+ dob);
//Console.WriteLine("Whats your First name?");
//Fname=Console.ReadLine();
//Console.WriteLine("Whats your Last name?");
//Lname = Console.ReadLine();

//Console.WriteLine(  "Your full name is "+ Fname +" "+ Lname);


//--------------------------------------------

// Arrays

//int[] ages = { 18, 14, 7 };
//string[] names = { "ayo", "Tobi", "Debby" };
////Console.WriteLine(string.Join(" ,",names));
////for (int i = 0; i < names.Length; i++)
////{
////    Console.WriteLine("My siblings is "+names[i]+ " and his age is " + ages[i]);
////}

////-------------------------------------------------------------

////List
//List<string> Siblings = new List<string>() ;
//for (int i = 0; i < names.Length; i++)
//{
//Siblings.Add(names[i]) ;
//Console.WriteLine("My siblings are "+  string.Join(" ,",Siblings));
//}
//Siblings.Remove("ayo");
//Console.WriteLine("My siblings are " + string.Join(" ,", Siblings));

//-------------------------------------------------------------------


//Console.WriteLine("Welcome to my game. Give me a random  number between 1 and 10");
//int num = Convert.ToInt32(Console.ReadLine());
//int ans = 0; int input = 0; int correctAns = 0; int numCount = 5;
//if (num > 0 && num <= 10)
//{
//    for (int i = 0; i < numCount; i++)
//    {
//        Console.WriteLine($"What is the vale of {num} multiplied by {num} .");
//        ans = num * num;
//        input = Convert.ToInt32(Console.ReadLine());
//        if (ans == input && numCount > 0)
//        {
//            Console.WriteLine($"Yay! You are a genius!You have {numCount - i - 1} tries to go!");
//            correctAns++;
//        }
//        Random r = new Random();
//        num = Convert.ToInt32(r) * 10;
//        num = num - 3;
//    }

//}
//else
//{
//    Console.WriteLine("Are you okay, In said give me a random  number between 1 and 10");



//}

//Console.WriteLine($"You got {correctAns} answers right!");

//----------------------------------------------------------

//int rating;
//string fullname = string.Empty;
//Console.WriteLine("Input your fullname");
//fullname = Console.ReadLine();
//Console.WriteLine("What do you rate yourself out of 10");
//rating = Convert.ToInt32(Console.ReadLine());
//if (rating > = 7 )
//{
//    Console.WriteLine("You must be a genius, lets see how you fair");
//}
//else
//{
//    Console.WriteLine("Why are you doubting yourself");
//}


//Console.WriteLine("Welcome to my game. Give me a random  number between 1 and 10");
//int num = Convert.ToInt32(Console.ReadLine());
//int ans = 0; int input = 0; int correctAns = 0; int numCount = 10;
//if (num > 0 && num <= 10)
//{
//    for (int i = 0; i < numCount; i++)
//    {
//        Console.WriteLine($"What is the vale of {num} multiplied by {num} .");
//        ans = num * num;
//        input = Convert.ToInt32(Console.ReadLine());
//        if (ans == input && numCount > 0)
//        {
//            Console.WriteLine($"Yay! You are a genius!You have {numCount - i - 1} tries to go!");
//            correctAns++;
//        }
//        Random r = new Random();
//        num = Convert.ToInt32(r) * 10;
//        num = num - 3;
//    }

//}
//else
//{
//    Console.WriteLine("Are you okay, In said give me a random  number between 1 and 10");



//}

//Console.WriteLine($"You got {correctAns} answers right!");
//----------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        int rating;
        string fullname = string.Empty;

        Console.WriteLine("Input your fullname:");
        fullname = Console.ReadLine();

        Console.WriteLine("What do you rate yourself out of 10?");
        rating = Convert.ToInt32(Console.ReadLine());

        if (rating >= 7)
        {
            Console.WriteLine("You must be a genius, let's see how you fare.");
        }
        else
        {
            Console.WriteLine("Why are you doubting yourself?");
        }

        Console.WriteLine("Welcome to my game. Give me a random number between 1 and 10:");
        int num = Convert.ToInt32(Console.ReadLine());
        int ans = 0;
        int input = 0;
        int correctAns = 0;
        int numCount = 10;

        if (num > 0 && num <= 10)
        {
            Random r = new Random();
            for (int i = 0; i < numCount; i++)
            {
                ans = num * num;
                Console.WriteLine($"What is the value of {num} multiplied by {num}?");
                input = Convert.ToInt32(Console.ReadLine());

                if (ans == input)
                {
                    Console.WriteLine($"Yay! You are a genius! You have {numCount - i - 1} tries to go!");
                    correctAns++;
                }
                else
                {
                    Console.WriteLine("That's not correct. Try again!");
                }

                
                num = r.Next(1, 11);
            }
        }
        else
        {
            Console.WriteLine("Are you okay? I said give me a random number between 1 and 10.");
        }

        Console.WriteLine($"You got {correctAns} answers right!");
    }
}


