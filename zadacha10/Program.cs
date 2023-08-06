// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Second(int num)
{
	if (num > 0)
		return num % 100 / 10;
	else return (num % 100 / 10) * -1;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000 || number <= -100 && number > -1000)
{
	int result = Second(number);
	Console.WriteLine($"Вторая цифра числа {number} -> {result}");
}
else Console.WriteLine("Неверное число");