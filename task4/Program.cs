// Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
// 4 3 1 => 2 6
// 2 6 9    4 6
// 4 6 2

//Задать размеры массива
int LEFTNUM = 4;
int RIGHTNUM = 4;

//Задаем исходный массив
int[,] array = CreateArray(LEFTNUM, RIGHTNUM);
Console.WriteLine("Source Array:");
PrintArray(array);

//Находим минимальный элемент с координатами
int minElement = array[0, 0];
int x = 0;
int y = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (minElement > array[i, j])
        {
            minElement = array[i, j];
            x = i;
            y = j;
        }
    }
}
Console.WriteLine("MinElement = " + minElement + "; x = " + x + "; y = " + y);
//----------------------------------------------------------------------------

//Используя метод удаляем строку и столбец и выводим на экран
int[,] changedArray = DeleteLineAndColumn(array, x, y);
PrintArray(changedArray);

//Метод для создания массива
int[,] CreateArray(int firstNum, int rightNum)
{
    int[,] array = new int[firstNum, rightNum];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
    return array;
}

//Метод для вывода массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод для удаления строки и столбца
int[,] DeleteLineAndColumn(int[,] array, int line, int column)
{
    int[,] changedArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i1 = 0, i2 = 0; i1 < array.GetLength(0); i1++)
    {
        if (i1 != line)
        {
            for (int j1 = 0, j2 = 0; j1 < array.GetLength(1); j1++)
            {
                if (j1 != column)
                {
                    changedArray[i2, j2] = array[i1, j1];
                    j2++;
                }
            }
            i2++;
        }
    }
    return changedArray;
}