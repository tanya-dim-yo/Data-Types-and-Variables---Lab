int n = int.Parse(Console.ReadLine());
bool flag;

for (int num = 1; num <= n; num++)
{
    flag = false;
    int sumOfDigits = 0;
    int digits = num;

    while (digits > 0)
    {
        sumOfDigits += digits % 10;
        digits /= 10;
    }

    if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
    {
        flag = true;
    }

    Console.WriteLine($"{num} -> {flag}");
}