// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// 4 3 1     (1,2) => 9
// 2 6 9
int LEFTNUM = 2;
int RIGHTNUM = 3;

int [,] array = CreateArray(LEFTNUM, RIGHTNUM);
int line = ReadNumber ("Enter number of Line: ");
int column = ReadNumber ("Enter number of Column: ");
Console.WriteLine("Array:");
PrintArray(array);

if (line < array.GetLength(0) && column < array.GetLength(1)){
    Console.WriteLine($"Element ({line} {column}) -> {array[line, column]}");
}
else Console.WriteLine("There is no such element");

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

int ReadNumber(string message){
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}