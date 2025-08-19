// public class Program
// {
//   static async Task Main()
//   {
//     // async Task<int> SumAsync(int a, int b)
//     // {
//       // await Task.Delay(1000);
//     //   return a + b;
//     // }

//     // async Task ShowSumAsync()
//     // {
//     //   int result = await SumAsync(5, 76);
//     //   Console.WriteLine(result);
//     // }


//     // await MyAsync();

//     // await ShowSumAsync();

//     int result = await MyAsync();
//     Console.WriteLine(result);
//   }

//   static async Task<int> MyAsync()
//   {
//     await Task.Delay(1009);
//     return 42;
//   }
//   // static async Task MyAsync()
//   //   {
//   //     await Task.Delay(1000);
//   //     Console.WriteLine("Void async finishied");
//   //   }
// }

public class Program
{
  static async Task<int> SumAsync(int a, int b)
  {
    return a + b;
  }
  static async Task Main()
  {
    Task<int> task1 = SumAsync(4, 10);
    Task<int> task2 = SumAsync(2, 3);

    int[] results = await Task.WhenAll(task1, task2);
    Console.WriteLine(results[0] + results[1]);

  }
}
