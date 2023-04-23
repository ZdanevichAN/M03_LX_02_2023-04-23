// поиск максимального через функцию
int num1 = 45, num2 = 50, num3 = 12;
int num4 = 32, num5 = 50, num6 = 1234;
int num7 = 424, num8 = 789, num9 = -90;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result<arg2) result = arg2;
    if (result<arg3) result = arg3;
    return result;
}
int max = Max(
            Max(num1, num2, num3),
            Max(num4, num5, num6),
            Max(num7, num8, num9)
            );
Console.Write(max);