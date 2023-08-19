int i;
Console.Write("The greatest from all who's lived, what's your input: ");
while (!int.TryParse(Console.ReadLine(), out i))
{
    Console.WriteLine("No");
}
int count = 0;
int num;
while (count < i)
{
    count++;
    num = count * count * count;
    Console.WriteLine(num);
}
