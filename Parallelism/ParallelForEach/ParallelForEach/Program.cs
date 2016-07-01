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

      Console.WriteLine("foreach example, no query, no parallelism...");
      System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
      stopwatch.Start();
      foreach (var item in testList) {
        Process(item);
      }
      stopwatch.Stop();
      Console.WriteLine("Elapsed time {0} ms.", stopwatch.ElapsedMilliseconds);
      Console.ReadLine();

      Console.WriteLine("Parallel.ForEach example...");
      stopwatch.Reset();
      stopwatch.Start();
      Parallel.ForEach(testList, item => Process(item));
      stopwatch.Stop();
      Console.WriteLine("Elapsed time {0} ms.", stopwatch.ElapsedMilliseconds);
      Console.ReadLine();


      Console.WriteLine("PLinq example...");
      stopwatch.Reset();
      stopwatch.Start();
      var parallelQuery = from item in testList.AsParallel()
                          where item % 10 == 0
                          select item;
      parallelQuery.ForAll((e) => Process(e));
      stopwatch.Stop();
      Console.WriteLine("Elapsed time {0} ms.", stopwatch.ElapsedMilliseconds);
      Console.ReadLine();

      Console.WriteLine("Linq example...");
      stopwatch.Reset();
      stopwatch.Start();
      var linqQuery = from item in testList
                          where item % 10 == 0
                          select item;
      foreach (var item in linqQuery) {
        Process(item);
      }
      stopwatch.Stop();
      Console.WriteLine("Elapsed time {0} ms.", stopwatch.ElapsedMilliseconds);
      Console.ReadLine();


    }

    public static void Process(int i) {
      System.Threading.Thread.Sleep(5);
    }
    }
}
