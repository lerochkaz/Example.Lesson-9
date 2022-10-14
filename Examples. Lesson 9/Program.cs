// Задача 70: Напишите программу, которая печатает последовательность чисел, где каждое следующее равно сумме двух предыдущих. На вход принимает 3 числа: n1, n2 и N, где n1 n2 - первые числа последовательности, N – длина последовательности	3 и 4, N = 5 -> 3 4 7 11 18	6 и 10, N = 4 -> 6 10 16 26 

// Console.Write("введите превое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Write("введите длину последовотельности: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.Write($"{num1} {num2} ");
// for (int i = 1; i <= n - 2; i++)
// {
//     int num3 = num1 + num2;
//     Console.Write($"{num3} ");
//     num1 = num2;
//     num2 = num3;
// }



// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из 2 букв, которые можно построить из букв этого алфавита.n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс

// Решение 1:
// string[] letters = new string[] { "а", "и", "с", "в" };

// for (int i = 0; i < letters.Length; i++)
// {
//     for (int j = 0; j < letters.Length; j++)
//     {
//         string word = letters[i] + letters[j];
//         Console.Write($"{word}, ");
//     }
// }


// Решение 2:
// string[] letters = new string[] { "а", "и", "с", "в" };

// int n = int.Parse(Console.ReadLine()!);
// PrintAllWords(letters, n);
// void PrintAllWords(string[] alphabet, int length, string prefix = "")
// {
//     if (length == 0)
//         Console.WriteLine(prefix);
//     else
//         for (int i = 0; i < letters.Length; i++)
//         {
//             PrintAllWords(alphabet, length - 1, prefix + letters[i]);
//         }
// }

// Задача 72: Задан массив, в котором хранится двоичное представление числа.Нужно вывести его десятичное представление	
// {0,1,1,1,1} -> 15

// int[] arr = new int[] { 0, 1, 1, 1, 1 };
// int num = 0;
// for (int i = arr.Length - 1; i >= 0; i--)
// {
//     num = num + (int)Math.Pow(2, arr.Length - 1 - i) * arr[i];
// }
// Console.WriteLine(num);



// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// входные данные:	data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }	info = {2, 3, 3, 1 }выходные данные:	1, 7, 0, 1




