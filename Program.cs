using System;

class Program
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number score you have in class.");
        float score = float.Parse(Console.ReadLine());
        if (score >= 100)
        {
            Console.WriteLine("Wow! " + score + "... That's impressive!");
            Console.WriteLine("Letter Grade: ");
        }
        if (score >= 90 && score < 100)
        {
            Console.WriteLine("Very Nice!");
            Console.WriteLine("Letter Grade: A");
        }
        if (score >= 80 && score < 90)
        {
            Console.WriteLine("Keep it up!");
            Console.WriteLine("Letter Grade: B");
        }
        if (score >= 70 && score < 80)
        {
            Console.WriteLine("You got this, keep working!");
            Console.WriteLine("Letter Grade: C");
        }
        if (score >= 60 && score < 70)
        {
            Console.WriteLine("Keep Trying!");
            Console.WriteLine("Letter Grade: D");
        }
        if (score < 60)
        {
            Console.WriteLine("Don't give up!");
            Console.WriteLine("Letter Grade: E");
        }
    }
}