Console.Write("Length: ");
double length = double.Parse(Console.ReadLine());
Console.Write("Width: ");
double width = double.Parse(Console.ReadLine());
Console.Write("Height: ");
double height = double.Parse(Console.ReadLine());
double pyramidVolume = (length * width * height) / 3.0;
Console.Write($"Pyramid Volume: {pyramidVolume:f2}");