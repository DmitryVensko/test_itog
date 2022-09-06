string[] array1 = new string [4] {"1234", "1567", "-2", "computer secience"};
string [] array2 = new string [array1.Length];
int count = 0;
void CheckArray(string[] array1, string[] array2)
{
	for (int i = 0; i < array1.Length; i++)
	{
		if (array1[i].Length <= 3)
            {
		        array2[count] = array1 [i];
		        count++;
            }
    }
}

CheckArray (array1, array2);

void PrintArray (string [] array)
{
	for (int i = 0; i < array2.Length; i++)
	{
		Console.WriteLine ($"{array2[i]}");
	}
}
PrintArray(array2);
