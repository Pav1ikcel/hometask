/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2



int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();


    for(int i = 0; i< size; i++)
        array[i] = rand.Next(100, 1000);
    return array;
}


void ShowArray( int[] array)
{
    for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");
    Console.WriteLine();
}


int GetAmountValue(int[] array)
{
    int amount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            amount++;
    }
    return amount;
}

int[] arr = CreateRandomArray(10);
ShowArray(arr);
Console.WriteLine("Even numbers count: " + GetAmountValue(arr));



*/






/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int minValue,int maxValue)
{
    int[] array = new int[size];
    Random rand = new Random();


    for(int i = 0; i< size; i++)
        array[i] = rand.Next(minValue, maxValue + 1);
    return array;
}


void ShowArray( int[] array)
{
    for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");
    Console.WriteLine();
}


int GetSumOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) // if the position is odd
            sum += array[i];
    }
    return sum;
}


    int[] arr = CreateRandomArray(10, 1, 100);
    ShowArray(arr);
    Console.WriteLine("Sum of elements in odd positions: " + GetSumOddPositions(arr));

*/



/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76


int[] CreateRandomArray(int size, int minValue,int maxValue)
{
    int[] array = new int[size];
    Random rand = new Random();


    for(int i = 0; i< size; i++)
        array[i] = rand.Next(minValue, maxValue + 1);
    return array;
}


void ShowArray( int[] array)
{
    for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");
    Console.WriteLine();
}


double GetDifferenceMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];


    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];


        if(array[i] < min)
            min = array[i];
    }


    return max - min;
}


    int[] arr = CreateRandomArray(10, 1, 100);
    ShowArray(arr);
    Console.WriteLine("Difference between max and min: " + GetDifferenceMaxMin(arr));
*/