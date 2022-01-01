// 1. Написать программу, которая из имеющегося целых чисел формирует массив из чисел, больших 8.

int [] array = new int [4];
Random rnd = new Random();
for (int i = 0; i <array.Length; i++)
{
    array[i] = rnd.Next(-10,20);
    Console.WriteLine(array[i]);
}
Console.WriteLine();

for (int index = 0; index < array.Length; index++)
{
    if (array[index]>8)
    Console.WriteLine( array[index]);
}



