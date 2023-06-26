char symbol = char.Parse(Console.ReadLine());
bool IsUpper = Char.IsUpper(symbol);

if (IsUpper)
{
    Console.WriteLine("upper-case");
}
else
{
    Console.WriteLine("lower-case");
}