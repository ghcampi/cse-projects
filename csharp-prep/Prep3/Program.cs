using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    //part 1 of the program
    /*{
        Console.WriteLine("What is the magic number?");
        int magic_num = int.Parse (Console.ReadLine());
        Console.WriteLine("What is your guess?");
        int guess_num  = int.Parse(Console.ReadLine());
        if (guess_num< magic_num)
        {
            Console.WriteLine("Higher");
        }
        else if(guess_num> magic_num)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guesed it! ");
        }

    }*/
    // Part 2 of the program

    /*{
      Console.Write("What is the magic number?: ");
      int magic_num = int.Parse (Console. ReadLine());
      Console.Write("What is your guess number? ");
      int guess_num = int.Parse(Console.ReadLine());
      while (guess_num != magic_num)
      {
        if (guess_num> magic_num)
        {
            Console.WriteLine("Lower");
        }
        else if (guess_num< magic_num)
        {
            Console.WriteLine("Higher" );
        }
        
            Console.Write("What is your guess number? ");
            guess_num = int.Parse(Console.ReadLine());
      }
        Console.WriteLine("You guessed it!");
    } */
// Part 3 of the program
    {
     Random random_numb = new Random();
     int magic_num = random_numb. Next(1,101); 
      Console.Write("What is your guess number? ");
      int guess_num = int.Parse(Console.ReadLine());
      while (guess_num != magic_num)
      {
        if (guess_num> magic_num)
        {
            Console.WriteLine("Lower");
        }
        else if (guess_num< magic_num)
        {
            Console.WriteLine("Higher" );
        }
        
            Console.Write("What is your guess number? ");
            guess_num = int.Parse(Console.ReadLine());
      }
        Console.WriteLine("You guessed it!");
    } 

}

   