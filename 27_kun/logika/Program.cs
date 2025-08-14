class Program
{
  static void Main()
  {
    Console.WriteLine("Son kiriting: ");

    int number = int.Parse(Console.ReadLine());

    int reversed = 0;
    int temp = number;

    while (temp > 0)
    {
      int digit = temp % 10;
      reversed = reversed * 10 + digit;
      temp /= 10;
    }

    Console.WriteLine("Reversed: " + reversed);
  }
}
