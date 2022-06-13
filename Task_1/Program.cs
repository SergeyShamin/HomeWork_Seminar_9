/* Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int Summ(int firstNumber, int secondNumber)
{
    int summ = 0;
    for (int i = firstNumber; i <= secondNumber; i++)
    {
        summ = summ + i;
    }
    return summ;
}

Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
int summ = Summ(firstNumber, secondNumber);
Console.WriteLine($"Сумма чисел от {firstNumber} до {secondNumber} равна {summ}");
