namespace natural_number__5
{
  internal class Program
  {
    static void Main(string[] args)
    {
    Console.WriteLine("Введите любое натуральное число, состоящее из 5 цифр:");
    var N=Convert.ToInt32(Console.ReadLine());
    int M;
    if (N >= 10_000 && N < 100_000)
    {
    Console.WriteLine("Новое число, которое образовалось путем исключения средней цифры:"); 
    M=(N/1000)*100 + N%100;
    }
    else
    {
    Console.WriteLine("Число не состоит из 5 цифр. Будьте внимательнее!");
    M = N;
    }
    Console.WriteLine(M);

    }
  }
}