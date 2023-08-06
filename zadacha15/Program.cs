// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool day(int num)
{
	return num > 5;
}

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number <= 7)
{
	bool result = day(number);
	Console.WriteLine(result ? "Да" : "Нет");
}
else Console.Write("Неверно обозначен день недели");