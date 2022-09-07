// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29 (возможно что в примере m и n перепутаны местами

// ДА, В ПРИМЕРЕ M и N ПЕРЕПУТАНЫ МЕСТАМИ.

Console.Write("Введите аргумент 'M' для вычисления ф-ии Аккермана(М,N) : ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите аргумент 'N' для вычисления ф-ии Аккермана(М,N) : ");
int n=Convert.ToInt32(Console.ReadLine());
if ((m>=0)&&(n>=0)) 
    {Console.WriteLine($"Значение ф-ии Аккермана(М,N) : {Akkerman(m,n)}");}
else {Console.WriteLine("Введены неверные аргументы");}

int Akkerman(int m, int n){
if (m == 0) {return n + 1;}
else
    if ((n == 0) && (m > 0)) {return Akkerman(m - 1, 1);}
    else {return Akkerman(m - 1, Akkerman(m, n - 1));}}
