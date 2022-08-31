Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
for (int i = 0; i < N; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
} 
}
else
{
    for (int i = 0; i > N; i--)
{
    Console.WriteLine(Math.Pow(i, 3));
} 
}