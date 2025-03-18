

class Program
{
    static void Main()
    {
        int randomNum = (new Random()).Next(1, 100);
        int guess = 5;
        int number;
        int tour = 0;

        while (guess > 0)
        {
            tour++;
            if (tour == 1)
            {
                Console.WriteLine("Welcome to the guessing game!");
            }
            Console.WriteLine("Enter your guess: ");
            number = Convert.ToInt32(Console.ReadLine());
            guess--;
            if (number == randomNum)
            {
                Console.WriteLine($"You got it! {randomNum} , you guessed in {tour} rounds");
                break;
            }
            else
            {
                if (number < randomNum)
                {
                    Console.WriteLine("Too low");
                }
                else if (number > randomNum)
                {
                    Console.WriteLine("Too high");
                }
            }
            Console.WriteLine("You have " + guess + " guesses left");
        }

    }
}
