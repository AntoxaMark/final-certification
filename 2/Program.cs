// 2 Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел

int [] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,20);
    Console.WriteLine(array[i]);
 
}
Console.WriteLine();
for (int index = 0; index < array.Length; index++)
{
    if ((array[index] % 2) == 0)
   Console.WriteLine("Четные числа "  +array[index]);

}





