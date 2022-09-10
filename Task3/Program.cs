// принимает на вход число и выдает таблицу кубов чисел от 1 до N

int [] GetNumCubes(int num)

{
	int[] numCubes = new int[num];

	for (int i = 1; i <= num; i++)
		{
			numCubes[i-1] = i*i*i;			
		}
	return numCubes;
}


Console.WriteLine("Введите число N: ");
int numN = int.Parse(Console.ReadLine());

int[] results = GetNumCubes(numN);

for (int i = 0; i < results.Length; i++)
	{
	Console.WriteLine(results[i]);
	}
