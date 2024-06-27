class Program{

static void Main(string[] args){
    bool correctGuess = false;
    Random random = new Random();

    int randomNum = random.Next(1, 11);

    Console.WriteLine("Welcome to the guessing game number.");
    Console.WriteLine("A number between 1 and 10 will be generated.");
    Console.WriteLine("You win if you can guess the correct number.");

    while (!correctGuess)
    {
        Console.WriteLine("Please enter your guess.");
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess > randomNum){
            
            Console.WriteLine("Your guess is too high try lower.");

        }
        else if (guess < randomNum){
            Console.WriteLine("Your guess is too low try higher.");
        }
        else{
            Console.WriteLine("Your guess is correct");
            correctGuess = true;
        }
    }

    Console.WriteLine("Well done you have won.");
}

}
