/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigitsNumber = SumDigitsNumber(number);
Console.WriteLine($"The sum of the digits in a number: {number} -> {sumDigitsNumber}");

int SumDigitsNumber(int num)
{
    int result = 0;
    while (num != 0)
    {
        result = (num%10) + result;
        num /=10;

    }
    return result;

} 



