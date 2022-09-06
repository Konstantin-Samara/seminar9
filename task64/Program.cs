// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m<=n) {
PrintNumbers(m,n);
Console.WriteLine();
void PrintNumbers(int m, int n) {
    if (m>n) {return;}
    else {
        Console.Write($"{m} ");m++;
        PrintNumbers(m,n); }}}
else {Console.WriteLine("Введен неправильный интервал");}
