using System;
using System.Runtime.InteropServices;
class HelloWorld {
  static void Main() 
  {
    Console.WriteLine("Hello World!");
    /*
    Task 1. 
    */
    Console.WriteLine("What is your first name? ");
    string fname = Console.ReadLine();
    
    Console.WriteLine("What is your last name? ");
    string lname = Console.ReadLine();
    
    Console.WriteLine($"Your name is {fname}, {fname} {lname}");
    
    /*
    Task 3. 
    */
    Console.WriteLine("Input your number");
    string tnumber = Console.ReadLine();

    int number = int.Parse(tnumber);
    int guess = 0;
    int count = 0;

    while (guess != number)
    {
      Console.WriteLine("Guess the number");

      string tguess = Console.ReadLine();
      guess = int.Parse(tguess);
      
      if (guess > number){
        Console.WriteLine("Lower");
      }

      if (guess < number){
        Console.WriteLine("Higher");
      }
    count += 1; 
    }
    Console.WriteLine("You guessed it!");
    Console.WriteLine($"Your number is: {number}");

    Console.WriteLine("do you want to play more? y/n");

    string answer = Console.ReadLine();
    ////
    if (answer == "Y" | answer == "y"){
      
      Console.WriteLine("Input your number");
    tnumber = Console.ReadLine();

    number = int.Parse(tnumber);
    guess = 0;
    count = 0;
    while (guess != number)
    {
      Console.WriteLine("Guess the number");

      string tguess = Console.ReadLine();
      guess = int.Parse(tguess);
      
      if (guess > number){
        Console.WriteLine("Lower");
      }

      if (guess < number){
        Console.WriteLine("Higher");
      }
    count += 1; 
    }
////
    }
    if (answer == "N" | answer == "n"){

    }
  }
}