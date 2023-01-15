/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Enter first number:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {exponentiation}");

int Exponentiation(int numA, int numB)
{
    if (numB > 0)
    {
        int count = 0;
        int result = 1;
        while (count < numB)
        {
            result = result * numA;
            count++; 
        }
        return result;

    }
    else 
    {
        numB *= -1;
        int count = 0;
        int result = 1;
        while (count < numB)
        {
            result = result * numA;
            count++; 
        }
        return result;

    }
}
