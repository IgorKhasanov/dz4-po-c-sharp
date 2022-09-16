// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumDigits(int num)
{
    if (num != 0) // не равно нулю
    {
        if (num < 0) num = -num; // делаем положительным
        int count = default;
        int lastnum = 0;
        int sum = 0;
        while (num > 0)
        {
            lastnum = num % 10;
            sum = sum + lastnum;
            num = (num - lastnum) / 10; // уменьшаем число на один порядок для поиска следующей последней цифры
            count++;
        }
        return sum;
    }
    return 1; // если число равно нулю
}
int result = SumDigits(number);
Console.Write(result);