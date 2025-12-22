using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        
        
        int CorrectCount = 0;
        int WrongCount = 0;
        int QuestionCount = 0;
        bool StopQuiz = false;


        Console.WriteLine("Substraction Quiz Challenge");
        Console.WriteLine("##################################");

        while (QuestionCount < 5 )
        {
            int num1 = rand.Next(0, 34);
            int num2 = rand.Next(0, 34);

            int larger = Math.Max(num1 , num2);
            int smaller = Math.Min(num1, num2);

            Console.Write($"What is {larger} - {smaller}? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int UserAnswer))
            {
                Console.WriteLine("Please enter valid whole number");
                continue;
            }

            int correctAnswer = larger - smaller;

            if (UserAnswer == correctAnswer)
            {
                Console.WriteLine("your answer is correct!");
                CorrectCount++;
            
                if (correctAnswer > 16)
                {
                    StopQuiz = true;
                }
            
            }
            else
            {
                Console.WriteLine($"Wrong answer. The correct answer is {correctAnswer}");
                WrongCount++;
            }
            QuestionCount++;
        }

        int TotalQuestions = CorrectCount + WrongCount;
        double percentage = (double)CorrectCount / TotalQuestions * 100;

        Console.WriteLine("##################################");
        Console.WriteLine($"Quiz Over! You answered {CorrectCount} out of {TotalQuestions} questions correctly.");
        Console.WriteLine($"Your score: {percentage}%");
        Console.WriteLine($"Wrong count is {WrongCount}");
        Console.WriteLine("##################################");
    }
}
