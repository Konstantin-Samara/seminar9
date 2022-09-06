// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m<n) {
    int sum=0;
    Console.WriteLine(SummNumbers(m,n));
    Console.WriteLine();
    int SummNumbers(int m, int n) {
        if (m>n) {return sum;}
        else {
            sum=sum+m;
            m++;
            SummNumbers(m,n); }
            return sum;}}
else {Console.WriteLine("Введен неправильный интервал");}
