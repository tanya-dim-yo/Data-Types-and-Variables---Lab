﻿int n = int.Parse(Console.ReadLine());
decimal sum = 0M;

for (int i = 1; i <= n; i++)
{
    sum += decimal.Parse(Console.ReadLine());
}

Console.WriteLine(sum);