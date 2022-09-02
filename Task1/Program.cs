Console.Clear(); 
Console.Write("Write number1 "); 
int number1 = int.Parse(Console.ReadLine()); 
Console.Write("Write number2 "); 
int number2 = int.Parse(Console.ReadLine()); 

if (number1 > number2) 
{ 
Console.WriteLine($"max = {number1}"); 
Console.WriteLine($"min = {number2}"); 
} 
else 
{ 
Console.WriteLine($"max = {number2}"); 
Console.WriteLine($"min = {number1}"); 
}