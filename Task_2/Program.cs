/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/ 
int A(int m, int n)
{ 
    if (m > 0 && n == 0)
        return A(m - 1, 1);

    if (m > 0 && n > 0)
        return A(m - 1, A(m, n - 1));

    return n + 1;
}

Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
int a = A(firstNumber, secondNumber);
Console.WriteLine($"A(m,n) = {a}");
