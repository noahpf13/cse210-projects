using System;

class Program
{
    static void Main(string[] args)
    {
      //get user's grade percentage, convert to int
      Console.Write("What is your grade percentage? ");
      string percentage = Console.ReadLine();

      
      int grade = int.Parse(percentage);

      string sign = "+";

    


      if (grade >= 90)
      {
        if (grade % 10 >= 7)
        {
            
        }
        
      }
      else if (grade >= 80)
      {
        Console.WriteLine("Your grade is B");
      }
      else if (grade >= 70)
      {
        Console.WriteLine($"Your grade is C{sign}");
      }
      else if (grade >= 60)
      {
        Console.WriteLine("Your grade is D");
      }
      else
      {
        Console.WriteLine("Your grade is F");
      }
    }
}