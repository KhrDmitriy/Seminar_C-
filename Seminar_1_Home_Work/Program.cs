// Задача 1.
// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
/*
int numa=-9;
int numb=-3;
if (numa > numb)
{
    Console.Write("max - > ");
    Console.WriteLine("A max=" + numa);
}
else
{
    Console.Write("max - >");
    Console.WriteLine("B max= " + numb);
}

// Задача 2.
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 22;
int b = 3;
int c = 9;
int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.Write("max ->");
Console.WriteLine(max);



// Задача 3.
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
// (делится ли оно на два без остатка).

int number = new Random().Next(1,100);
Console.WriteLine(number);

if(number % 2 == 0)
    Console.Write("число чётное");
else
    Console.WriteLine("НЕчётное");

*/

// Задача 4.
// Напишите программу, которая на вход принимает число (N), а на входе показывает все чётные числа от 1 до N.

int num = 1;
Console.Write("N");
int N = Convert.ToInt32(Console.ReadLine());

for(num=1; num<N; num++)
{
if(num % 2==0)
    Console.WriteLine("Чётное число" + num);
//else
    //Console.WriteLine("НЕчётное число" + num);
}