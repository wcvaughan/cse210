using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade.
        (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)
        */
        Console.WriteLine("What is your grade percentage?");
        int gradePercent = int.Parse(Console.ReadLine());

        string letterGrade;
        string message = "Great work this term!";

        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }
        else
        {
            letterGrade = "F";
            message = "Work hard and maybe next term we'll do better!";
        }

        Console.WriteLine($"Your letter grade for this term is: {letterGrade}");
        Console.WriteLine($"{message}");


        /*Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out.
        Add a separate if statement to determine if the user passed the course,
        and if so display a message to congratulate them. If not, display a different message to encourage them for next time.*/

        /*Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block,
        instead create a new variable called letter and then in each block, set this variable to the appropriate value.
        Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.*/
    }
}