using System;

namespace gitHub
{
  class Program
  {
    static void Main(string[] args)
    {
      int sum1 = 100 + 50;     // 150 (100 + 50)
      int sum2 = sum1 + 300;   // 400 (150 + 300)
      int sum3 = sum2 + sum2;  // 800 (400 + 400)
      Console.WriteLine(sum1);
      Console.WriteLine(sum2);
      Console.WriteLine(sum3);
     }
  }
}