using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderConcatenation {
  class Program {
    static void Main(string[] args) {

      string baseString = "I am a base string";
      int iterations = 50000;

      Console.WriteLine("Tap a key to begin StringBuilder test");
      Console.ReadKey(true);

      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < iterations; i++) {
        builder.Append(baseString);
      }
      string testString = "Test";
      testString = builder.ToString();
      Console.WriteLine("Result was {0} characters long.", testString.Length);
      Console.ReadKey(true);
    }
  }
}
