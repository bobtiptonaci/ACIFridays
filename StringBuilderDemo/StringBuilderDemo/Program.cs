using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo {

  public delegate void StringMaker(string baseString, int iterations);

  class Program {

    static void Main(string[] args) {
      int iterations = 10000;
      string baseString = "I am a string that wants some friends.";
      string endString = string.Empty;

      Console.WriteLine("Tap any key to get started...");
      Console.ReadKey(true);

      StringMaker maker = StringConcatenation;
      BenchMarker.Execute("String concatenation", baseString, iterations, maker);

      maker = BuilderAppender;
      BenchMarker.Execute("StringBuilder append", baseString, iterations, maker);

      // anonymous function!!!
      BenchMarker.Execute("Anonymouse", baseString, iterations, 
        delegate (string anonbase, int anonerations) {
        for (int i = 0; i < anonerations; i++) { 
            // do nothing 
          }
          Console.Write("Mouse was here!\r\n");
      });

      // lambda method!!!
      StringMaker lambda = (lambdaString, lambdaIterations) => {
        for (int i = 0; i < lambdaIterations; i++) {
          // do nothing, but in a lambda way!
        }
      };

      BenchMarker.Execute("Lambdata - the forbidden type", baseString, iterations,
        lambda);
    }

    public static void StringConcatenation(string baseString, int iterations) {
      string endString = string.Empty;
      for (int i = 0; i < iterations; i++) {
        endString += baseString;
      }
      Console.WriteLine("Result is {0} characters long.", endString.Length);
    }

    public static void BuilderAppender(string baseString, int iterations) {
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < iterations; i++) {
        builder.Append(baseString);
      }
      Console.WriteLine("Result is {0} characters long.", builder.Length);
    }
  }

  static class BenchMarker {
    public static void Execute(string caption, string baseString, int iterations, StringMaker process) {
      Console.WriteLine("Starting {0} with {1} iterations...", caption, iterations);
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      process(baseString, iterations);
      stopwatch.Stop();
      Console.WriteLine("Processing took: " + stopwatch.ElapsedMilliseconds + " milliseconds.");
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey(true);
    }
  }
}
