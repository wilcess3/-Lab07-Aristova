//Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// for (int i = days.Length - 1; i >= 0; i--) {
//     Console.WriteLine($"{i}: {days[i]}");
// }


//Задание 1.2
// double[] temps = { -5, -2, 0, 3, 7, 10, 8};
// foreach (double t in temps) {
//     Console.Write(t);
// }
//     Console.WriteLine();


//Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// foreach (int price in prices)
// {
//     sum +=price;
// }
// double srednee = (double)sum / prices.Length;

// int count = 0;
// foreach (int price in prices)
// {
//     if (price > 100)
//     {
//         count += 1;
//     }
// }
// Console.WriteLine($"Сумма: {sum}");
//         Console.WriteLine($"Среднее: {srednee}");
//         Console.WriteLine($"Дороже 100: {count}");


// Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//         {
//             min = prices[i];
//         }
// }
// int max = prices[0];
// int indexMax = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] > max)
//         {
//             max = prices[i];
//             indexMax = i;
//         }
// }
// Console.WriteLine($"Минимум: {min}");
// Console.WriteLine($"Индекс самого дорогого: {indexMax}");


//Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0) balance[i] = 0;
// }
// foreach (int b in balance)
// {
//     Console.Write(b + " ");
// }


//Задание 5
// int[] spisok = new int[5];
// for (int i = 0; i < spisok.Length; i++)
// {
//     Console.Write($"Введите число: ");
//     spisok[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Массив в обратном порядке:");
// for (int i = spisok.Length - 1; i >= 0; i--)
// {
//     Console.Write(spisok[i] + " ");
// }
// Console.WriteLine();
// int count = 0;
// foreach (int n in spisok)
// {
//     if (n % 2 == 0) count++;
// }
// Console.WriteLine($"Чётных чисел: {count}");




//Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };

// Console.Write("Введите имя: ");
// string input = Console.ReadLine();

// int index = -1;
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == input)
//     {
//         index = i;
//         break;
//     }
// }

// if (index != -1)
//     Console.WriteLine($"Позиция: {index}");
// else
//     Console.WriteLine("Не найдено");





//Журнал оценок
int[] ocenki = { 2,4,5,3,3,5 };
Console.Write("Оценки: ");
foreach (int g in ocenki)
{
    Console.Write(g + " ");
}
Console.WriteLine();

int sum = 0;
foreach (int g in ocenki)
{
    sum += g;
}
double srednee = (double)sum / ocenki.Length;
Console.WriteLine($"Средняя: {srednee}");

int max = ocenki[0];
int min = ocenki[0];
foreach (int g in ocenki)
{
    if (g > max)
    {
        max = g;
    }
    if (g < min)
    {
        min = g;
    }
}
Console.WriteLine($"Максимум: {max}, минимум: {min}");

int count2 = 0;
int count5 = 0;
foreach (int g in ocenki)
{
    if (g == 2)
    {
        count2++;
    }
    if (g == 5)
    {
        count5++;
    }
}
Console.WriteLine($"Двоек: {count2}, пятёрок: {count5}");

if (srednee >= 4.5)
{
    Console.WriteLine("Отличник");
}
else if (srednee >= 3.5)
{
    Console.WriteLine("Хорошист");
}
else
{
    Console.WriteLine("Есть над чем поработать");
}


//Доп задание
int[] arr = { 1, 2, 3, 4, 5, 6 };

int temp;
for (int i = 0; i < arr.Length / 2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}

foreach (int n in arr)
{
    Console.Write(n + " ");
}