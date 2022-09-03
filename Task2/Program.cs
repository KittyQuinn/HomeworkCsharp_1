Console.Clear(); 
Console.Write("Write number1 "); 
int number1 = int.Parse(Console.ReadLine()); 
Console.Write("Write number2 "); 
int number2 = int.Parse(Console.ReadLine()); 
Console.Write("Write number3 "); 
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number2 > max) 

    { 
Console.WriteLine($"max = {number2}");  
}

if (number3 > max)
{
    Console.WriteLine($"max = {number3}");
}

else
{
    Console.WriteLine($"max = {number1}");
}
