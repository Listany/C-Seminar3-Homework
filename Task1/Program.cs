// Программа принимает на вход 5значное число и проверяет, является ли оно палиндромом

System.Console.Write("Введите пятизначное число: ");

try
{
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 99999)
    {
        System.Console.WriteLine("Вы ввели не пятизначное число");
    }
    else
    {
        int numRevers = (num % 10 * 10000) + ((num / 10 % 10)*1000) + ((num / 100 % 10)*100) + ((num /1000 %10)*10) + num/10000;

    if (num == numRevers)
    {
        System.Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Введенное число НЕ палиндром!");
    }
    }    
}
catch
{
    System.Console.WriteLine("Вы ввели некорректные данные");
}

