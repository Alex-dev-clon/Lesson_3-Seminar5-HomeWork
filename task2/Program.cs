// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// 4 3 1   =>  4 6 2
// 2 6 9       2 6 9
// 4 6 2       4 3 1
int LEFTNUM = 5;
int RIGHTNUM = 5;

int [,] array = CreateArray(LEFTNUM, RIGHTNUM);
Console.WriteLine("Source Array:");
PrintArray(array);
Console.WriteLine("Changed Array:");
PrintArray(ChangeArray(array));

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

int [,] ChangeArray (int [,] array){
    int temp = array.GetLength(0) - 1;
    int [] arrayTemp = new int [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++){
           arrayTemp[j] = array[0,j];
           array[0,j] = array[temp, j];
           array[temp,j] = arrayTemp [j];
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