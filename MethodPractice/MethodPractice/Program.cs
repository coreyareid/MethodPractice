// Exercise 1

    Console.WriteLine("What is your name?");
    var yourName = Console.ReadLine();

    Console.WriteLine("What is your favorite color?");
    var favoriteColor = Console.ReadLine();

    Console.WriteLine("What is your favorite animal?");
    var favoriteAnimal = Console.ReadLine();

    Console.WriteLine("What is your favorite band?");
    var band = Console.ReadLine();


    Console.WriteLine($" Hello, {yourName} and welcome to this exercise. I see you like " +
        $"the color {favoriteColor}, maybe if you had a {favoriteColor} " +
        $"{favoriteAnimal} you wouldn\'t feel lonely " +
        $"and need to listen to {band} to cope with your sadness.");
// Exercise 2

static int Addition(int x, int y)
{
    Console.WriteLine("Put in two numbers to add together");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
    return x + y;
}

int answer = Addition(0, 0);
Console.WriteLine($"your result is: {answer}");


static int Multiplication( int numOne, int numTwo)
{
    Console.WriteLine("Put in two numbers you want to be multiplied.");
    numOne = Convert.ToInt32(Console.ReadLine());
    numTwo = Convert.ToInt32(Console.ReadLine());
    return numOne * numTwo;
}

int answerTwo = Multiplication(0, 0);
Console.WriteLine($"You multiplied two numbers to get: {answerTwo}");

static int Subtraction( int thingOne, int thingTwo)
{
    Console.WriteLine("Put in two numbers to subtract.");
    thingOne = Convert.ToInt32(Console.ReadLine());
    thingTwo = Convert.ToInt32(Console.ReadLine());
    return thingOne - thingTwo;
}

int answerThree = Subtraction(0, 0);
Console.WriteLine($"Your answer for subtractions is: {answerThree}");

static int AddSeveralNumbers(params int[] numbers)
{
    int total = 0;
    foreach (int number in numbers)
    { total += number;
    }
    return total;
}
Console.WriteLine("Add 4 numbers to get the total.");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = Convert.ToInt32(Console.ReadLine());
int[] numbersInMethod = { num1, num2, num3, num4 };
int addedNumbers = AddSeveralNumbers(numbersInMethod);
Console.WriteLine($"Youre total is: {addedNumbers}.");