// Написать программу, которая из иеющегося массива строк формирует сассив из строк, длина которых
// меньше либо равна 3 символа.

void PrintArray(string[] array) // функция для вывода массива в консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "'   ");
    }
    Console.WriteLine("]");
}

string[] LessThanThreeSigns(string[] originalArray)// вернет новый массив с элементами не длиньше 3 символов
{
    string[] processedArray = new string[0];

    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            Array.Resize(ref processedArray, processedArray.Length + 1);
            processedArray[processedArray.Length - 1] = originalArray[i];
        }
        else continue;
    }

    return processedArray;
}

//main
/////петля для приема элементов исходного массива с клавиатуры
Console.WriteLine("Input array element or input '0000' to finish.");

int elementNumber = 0;
string[] inputArray = new string[0];


while (true)
{
    string temp = string.Empty;
    Console.Write("Input element №" + elementNumber + ": ");
    temp = Convert.ToString(Console.ReadLine());

    if (temp == "0000") break;
    else
    {
        Array.Resize(ref inputArray, inputArray.Length + 1);
        inputArray[elementNumber] = temp;
    }
    elementNumber++;
}
/////

Console.Write("Original Array -> ");
PrintArray(inputArray);
Console.Write("Processed Array ->");
PrintArray(LessThanThreeSigns(inputArray));


