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
    Task 2. 
    */
    Console.WriteLine("Input your number");
    string tnumber = Console.ReadLine();
    int number = int.Parse(tnumber);
    int guess = 0;
    while (guess != number)
    {
      Console.WriteLine("Guess the number");
      string tguess = Console.ReadLine();
      guess = int.Parse(tguess);
      if (guess > number){
        
      }
    }
    Console.WriteLine(number);
  }
}