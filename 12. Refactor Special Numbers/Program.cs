int number = int.Parse(Console.ReadLine());
bool isSpecial;

for (int currentNumber = 1; currentNumber <= number; currentNumber++)
{
    int numberCopy = currentNumber;
    int sum = 0;
    isSpecial = false;

    while (numberCopy > 0)
    {
        sum += numberCopy % 10;
        numberCopy /= 10;
    }

    if (sum == 5 || sum == 7 || sum == 11)
    {
        isSpecial = true;
    }
    
    Console.WriteLine($"{currentNumber} -> {isSpecial}");
}