using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade in percent? ");
        string grade = Console.ReadLine();
        int percent_num = int.Parse(grade);

        string grade_letter = "";

        if (percent_num >= 90)
        {
            grade_letter = "A";
        }
        else if(percent_num >= 80)
        {   
            grade_letter = "B";
        }
        else if (percent_num >= 70)
        { 
            grade_letter = "C";
        }
        else if (percent_num >= 60)
        {
            grade_letter = "D";
        }
        else 
        {
            grade_letter = "F";
        }
        Console.WriteLine ($"Your grade is: {grade_letter} ");
        if (percent_num>=70)
        {
            Console.WriteLine("Congratulations; You passed !!");
        
        }
        else
        {
            Console.WriteLine(" Sorry,You need review the topic and try again");
        }

    }
}