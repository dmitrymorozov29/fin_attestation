// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.WriteLine("Приветсвтую Вас, уважаемый пользователь!"); // Вводим приветствие пользователя
static void Main() // записываем метод для заполнения исходного (материнского) массива
        {
            Console.Write("Введите количество строк (элементов массива), которые хотите ввести: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
            string[] array_mother = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите строку №{0}:\r\n    ", i + 1);
                array_mother[i] = Console.ReadLine(); //Заполняем его
            }
            Console.WriteLine("Вы ввели следующие строки:"); // Проверка
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array_mother[i]);
            }
            Console.Write("Нажмите [Enter] для выхода...");
            Console.ReadLine();
        }
Main();
string[] array_son = new string [array_mother.Lenght]; // создаем второй массив (ответ задачи) с длиной, равной длине исходного массива
void MotherToSon(string[] array_mother, string[] array_son) // создаем метод отбора элементов исходного массива для заполнения ответа
{
    int count = 0;
    for (int i = 0; i < array_mother.Lenght; i++) // цикл прохода по элементам материнского массива
    {
        if(array_mother[i]<=3) // записываем условие отбора элементов первого массива во второй
        {
            array_son[count]=array_mother[i]; // заполнение второго массива, если условие выполнено
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for(int i = 0; i< array.Lenght; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
MotherToSon(array_mother, array_son);
PrintArray(array_son);