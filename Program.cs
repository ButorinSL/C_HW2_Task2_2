// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета (решать только при помощи операций % и /).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ReadInt(string message) // int - тип возвращаемого значения, ReadInt - название функции, message - параметр
    {
    Console.Write($"{message} >"); // Вызов функции печати в консоль
    int value = Convert.ToInt32(Console.ReadLine()); // Ввод строки из консоли и преобразование в целое
    return value; // Возвращаемое значение
    }

int number = ReadInt("Введите число"); // Вызов функции ввода числа
int numberUser = number;
if (number < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
     while (number > 999)
        {
            number = number / 10;
        }
    int digit3 = number % 10;
    Console.WriteLine($"Третья цифра в числе {numberUser} это {digit3}");
}

