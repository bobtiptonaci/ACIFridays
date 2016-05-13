using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("Tap a key to continue...");
      Console.ReadKey(true);

      int iterations = 50000;
      string baseString = "I am a base string";
      string result = string.Empty;

      for (int i = 0; i < iterations; i++) {
        result += baseString;
      }

      Console.WriteLine("Result is {0} characters.", result.Length);
      Console.ReadKey(true);
    }
  }
}
