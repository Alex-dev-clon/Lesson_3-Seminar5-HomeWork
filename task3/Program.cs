// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2
int LEFTNUM = 3;
int RIGHTNUM = 3;

int [,] array = CreateArray(LEFTNUM, RIGHTNUM);
Console.WriteLine("Source Array:");
PrintArray(array);
int minLine = 0;
int index = 0;
int sum = 0;

for (int j = 0; j < array.GetLength(1); j++){
    sum += array[0,j];
}
minLine = sum;

for (int i = 0; i < array.GetLength(0); i++){
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++){
        sum += array[i,j];
    }
    if (minLine > sum) {
        minLine = sum;
        index = i;
    }
}
Console.WriteLine("Min Line has index: " + index);


int [,] CreateArray (int firstNum, int rightNum){
    int [,] array = new int [firstNum, rightNum];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = rand.Next(0, 10);
        }
    }
    return array;
}

void PrintArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}