// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b >= 0)
{
    int St(int a1, int b1)
    {
        int exp = 1;
        int i = 1;
        while (i <= b1)
        {
            exp = exp * a1;
            i += 1;
        }
        return exp;
    }
    int result = St(a, b);
    Console.Write($"Число {a} в степени {b} равно {result}");
}
else Console.Write("Введите число B > 0");