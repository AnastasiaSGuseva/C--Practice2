//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


//Я понимаю, что это не оптимальный способ, просто попытка решить
//задачу с помощью математики)


Console.WriteLine("Введите число: ");

string number = Console.ReadLine();
int N = number.Length;
int numb1 = Convert.ToInt32(number);


if (numb1 < 100)
        Console.WriteLine("Третьей цифры нет.");
else
    {
        int tenPower = Convert.ToInt32(Math.Pow(10,N-3));
        int thirdElement = ((numb1/tenPower) % 10);
        Console.Write("Третья цифра ");
        Console.Write(thirdElement);
    }

