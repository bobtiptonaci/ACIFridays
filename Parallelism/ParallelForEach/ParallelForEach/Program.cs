using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ParallelForEach {
  class Program {
    static void Main(string[] args) {
      List<int> testList = new List<int>();
      for (int i = 0; i < 1000; i++) {
        testList.Add(i);
      }

      System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
      stopwatch.Start();
      foreach (var item in testList) {
        Process(item);
      }
      stopwatch.Stop();
      Console.WriteLine("Elapsed time {0} ms.", stopwatch.ElapsedMilliseconds);
      Console.ReadLine();

      stopwatch.Reset();
      stopwatch.Start();
      Parallel.ForEach(testList, item => Process(item));
      stopwatch.Stop();
      Console.WriteLine("Elapsed time {0} ms.", stopwatch.ElapsedMilliseconds);
      Console.ReadLine();
    }

    public static void Process(int i) {
      System.Threading.Thread.Sleep(5);
    }
    }
}
