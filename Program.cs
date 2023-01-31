int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(1, 1000);
    return result;
}

int FindNumber(int number)
{   
int ThirdNumber = number%10; 

return ThirdNumber;
}

int number = GetNumber();
int result = FindNumber(number);


Console.WriteLine($"{number}");

if (number/100 == 0)
{
    Console.WriteLine("Нет числа");
}
else
{
    Console.WriteLine($"{result}");
}
