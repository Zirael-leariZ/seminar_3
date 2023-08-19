// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Provide any number: ");
string x = Console.ReadLine();
string d = "";
int i = 0;

for (i=0; i < x.Length; i++)
{
    d = d + x[x.Length - 1 - i];
}
if (d == x)
{
    Console.WriteLine ("Yes");
}
else 
{
    Console.WriteLine ("No");
}

// Console.WriteLine("Provide any number: ");
// string x = Console.ReadLine();

// char a = x[4];
// int a1 = Convert.ToInt32(a);
// char b = x[3];
// int b1 = Convert.ToInt32(b);
// char c = x[2];
// int c1 = Convert.ToInt32(c);
// char d = x[1];
// int d1 = Convert.ToInt32(d);
// char e = x[0];
// int e1 = Convert.ToInt32(e);

// if (a1 + b1 + c1 + d1 + e1 == e1 + d1 + c1 + b1 + a1)
// {
//     Console.WriteLine("Da");
// }
// else 
// {
//     Console.WriteLine("No");
// }
