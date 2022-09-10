// принимает на вход число и выдает таблицу кубов чисел от 1 до N

double [] GetNumCubes(double num)

{
    double[] numCubes = new double[Convert.ToInt32(num)];

	for (int i = 1; i <= num; i++)
		{
			numCubes[i-1] = Math.Pow(i, 3);			
		}
	return numCubes;
}


Console.WriteLine("Введите число N: ");
double numN = double.Parse(Console.ReadLine());

double[] results = GetNumCubes(numN);

for (int i = 0; i < results.Length; i++)
	{
	Console.WriteLine(results[i]);
	}
