// Задача 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
int numberLine = UserInput("Количество строк в новой таблице = ");
int numberColumb = UserInput("Количество столбцов в новой таблице = ");
int minimum = UserInput("Введите минимальное значение = ");
int maximum = UserInput("Введите максимальное значение = ");
if (RectagularMatrix(numberLine,numberColumb))
{
int[,] createRandomMatrix = CreateRandomMatrix(numberLine, numberColumb, minimum, maximum);    
PrintArrayMatrix(createRandomMatrix);
int[] summLineInMatrix = SummLineInMatrix(createRandomMatrix);
Console.WriteLine("Сумма элементов в каждой строке:");
PrintArray(summLineInMatrix);
Console.WriteLine($"Сумма элементов минимальна в {MinArrey(summLineInMatrix) + 1} строке");
}
else
{
Console.WriteLine("Ошибка! Таблица должна быть прямоугольной повторите ввод");  
}


int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine($"{matrix[i, matrix.GetLength(1) - 1]} |");
    }
}
bool RectagularMatrix(int line, int columb)
{
    if (line == columb)
    {
    return false;
    }
    return true;
}
int[,] CreateRandomMatrix(int line, int columb, int min, int max)
{
    int[,] matrix = new int[line, columb];
    
    {

        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < columb; j++)
            {
                matrix[i, j] = new Random().Next(min, max + 1);
            }
        }
    }
    return matrix;
}
int MinArrey(int[] arrey)
{
   int minimum = arrey[0];
   int minIndex = 0; 
   for (int i = 0; i < arrey.Length; i++)
            {
                if(minimum > arrey[i])
                {
                    minimum = arrey[i];
                    minIndex = i;
                }  
            }
    return minIndex;
}
int[] SummLineInMatrix(int[,] matrix)
{
    int[] summLine = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summLine[i] = summLine[i] + matrix[i,j]; 
        }
}
return summLine;
}
void PrintArray(int[] arrey)
{
Console.Write("[ ");
    for (int i = 0; i < arrey.Length - 1; i++)
    {
        Console.Write($"{arrey[i]}, ");
    }
Console.WriteLine($"{arrey[arrey.Length - 1]} ]");
}