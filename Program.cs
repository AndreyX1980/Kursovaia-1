//

Console.WriteLine("Сколько строк массива планируете ввести?");
int countArrayValue = int.Parse(Console.ReadLine());

string [] injectArray = new string [countArrayValue];
 
 string [] FillArray (string [] array)
 {
	for (int i = 0; i < countArrayValue; i++)
	{
		Console.WriteLine($"Введите {i} значение:");
		array[i] = Console.ReadLine();
	}
	return array;
}

string [] SortArray (string [] array)
{
	int countNecessaryValue = 0;
	string arrayValue = string.Empty;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3) countNecessaryValue++;
	}

	string [] finalArray = new string [countNecessaryValue];
	int index = 0;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3)
		{
			finalArray[index] = array[i];
			index++;
		}
	}
	return finalArray;
}

void PrintArray (string [] array)
{
	if (array.Length == 0) Console.WriteLine("Массив не имеет значений!");
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"  [{array[i]}]");
		}
}

FillArray(injectArray);

string [] finalArray = SortArray(injectArray);

Console.WriteLine("\n Введенные значения массивов:");
PrintArray(injectArray);

Console.WriteLine("\n Среди них с длинной (<) либо = (3) символа:");
PrintArray(finalArray);
Console.WriteLine();