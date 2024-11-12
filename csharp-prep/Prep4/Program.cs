using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputUser = -1;
        Console.WriteLine("Enter a list of numbers, tipe 0 when finished.");
        while (inputUser != 0)
        {
            Console.Write("Enter a number ");

            string responseUser = Console.ReadLine();
            inputUser = int.Parse(responseUser);
            if(inputUser !=0)
            {
                numbers.Add(inputUser);
            }  

        }
        //sum of the list.
        int sum_numbers = 0;
        foreach (int number in numbers)
        {
            sum_numbers += number;
           
        }
        Console.WriteLine($"The sum is: {sum_numbers} ");
        // Average
        float average = ((float)sum_numbers)/ numbers.Count;
        Console.WriteLine($"The average is:{average} ");
        // Largest number
        int largest = numbers [0];
        foreach (int number in numbers)
        {
            if(number > largest)
            {
                largest = number;
            }
        }
 Console.WriteLine($"The largest number is: {largest}");



    }

}