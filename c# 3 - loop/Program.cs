namespace c__3___loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //Random random = new Random();
            //int secret = random.Next(1, 101);
            //int maxAttempts = 7;
            //int attempts = 0;
            //bool guessed = false;

            //Console.WriteLine("I'm thinking of a number between 1 and 100. You have 7 attempts.");

            //while (attempts < maxAttempts)
            //{

            //    if (!int.TryParse(Console.ReadLine(), out int guess))
            //    {
            //        Console.WriteLine("Error: please enter a valid integer number.");
            //        continue;
            //    }

            //    attempts++;

            //    if (guess < secret)
            //    {
            //        Console.WriteLine("Too low!");
            //    }
            //    else if (guess > secret)
            //    {
            //        Console.WriteLine("Too high!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Correct!");
            //        guessed = true;
            //        break;
            //    }
            //}

            //if (guessed)
            //{
            //    Console.WriteLine($"You guessed it in {attempts} attempt(s).");
            //}
            //else
            //{
            //    Console.WriteLine($"Game over! The correct number was {secret}.");
            //}

            //task2
            int studentCount;

            Console.WriteLine("Enter the number of students:");
            while (!int.TryParse(Console.ReadLine(), out studentCount) || studentCount <= 0)
            {
                Console.WriteLine("Error: please enter a positive integer.");
            }

            int passed = 0;
            int failed = 0;

            for (int i = 1; i <= studentCount; i++)
            {
                int score;

                Console.WriteLine($"Enter the score for student {i} (0-100):");
                while (!int.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100)
                {
                    Console.WriteLine("Error: score must be an integer from 0 to 100. Try again:");
                }

                string grade;
                if (score >= 90) grade = "A";
                else if (score >= 80) grade = "B";
                else if (score >= 70) grade = "C";
                else if (score >= 60) grade = "D";
                else grade = "F";

                Console.WriteLine($"Student {i}: score = {score}, grade = {grade}");

                if (grade == "F")
                    failed++;
                else
                    passed++;
            }

            Console.WriteLine($"Passed: {passed}");
            Console.WriteLine($"Failed: {failed}");
        }
    }
}
