using System;

class Program
{
    static void Main(string[] args)
    {
      //get user's grade percentage, convert to int
      Console.Write("What is your grade percentage? ");
      string userPercentage = Console.ReadLine();
      int numPercentage = int.Parse(userPercentage);
      //initialize blank
      string grade;
      string sign;


      if (numPercentage >= 90)
      {
        grade = "A";      
      }
      else if (numPercentage >= 80)
      {
        grade = "B";
      }
      else if (numPercentage >= 70)
      {
        grade = "C";
      }
      else if (numPercentage >= 60)
      {
        grade = "D";
      }
      else
      {
        grade = "F";
      }

      if (numPercentage % 10 >= 7 && !(grade == "A") && !(grade == "F"))
      {
        sign = "+";
      }
      else if (numPercentage % 10 <= 3 && !(grade == "F"))
      {
        sign = "-";
      }
      else
      {
        sign = "";
      }

      Console.WriteLine($"Your grade is {grade}{sign}");
    }
}