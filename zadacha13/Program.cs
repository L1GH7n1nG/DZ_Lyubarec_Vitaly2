// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Third(int num)
{
	if (num > 0)
	{
		while (num > 999) // кол-во "9" номер искомой цифры. 9999 - 4 искомая цифра.
		{
			num = num / 10;
		}
		int result = num % 10;
		return result;
	}
	else
	{
		while (num < -999)
		{
			num = num / 10;
		}
		int result = (num % 10) * -1;
		return result;
	}
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 || number <= -100)
{
	int result_main = Third(number);
	Console.WriteLine($"Третья цифра числа {number} -> {result_main}");
}
else Console.Write("третьей цифры нет");