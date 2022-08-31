Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
int modul = Math.Abs(number);

if (modul < 9999)
{
    Console.WriteLine("Число  не пятизначное");
}
else
if (modul > 99999)
{
    Console.WriteLine("Число  не пятизначное");
}
else 
{
    var digits = modul.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
    if (Math.Abs(digits[0]) == Math.Abs(digits[4]) || Math.Abs(digits[1]) == Math.Abs(digits[3])) Console.WriteLine("Число палиндром");
    else Console.WriteLine("Число  не палиндром");
}


