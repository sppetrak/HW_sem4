//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//(числа берете любые)

int[] array = new int[8];

Random arr = new Random();
 
Console.WriteLine("Массив из 8 чисел в Рандоме");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
   Console.Write("{0} ", array[i]);
}
