using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAwaitExperiment {
  public static class NumberGetter {
    private const long SLOWFACTOR = 1000000000;

    // Things to note:
    // If an async method doesn't have an await in it, it will run synchronously.
    // You can block the UI thread even if you call the long running method after your ui update.
    // 
    public static async Task<int> GetRandomAsync() {
      int result = await GetRandomSlowlyAsync();
      return result;
    }

    private static async Task<int> GetRandomSlowlyAsync() {
      await Task.Run(() => { for (long i = 0; i < SLOWFACTOR; i++) { } });
      return GetRandom();
    }
    public static int GetRandomSlowly() {
      for (long i = 0; i < SLOWFACTOR; i++) { };
      return GetRandom();
    }
    public static int GetRandom() {
      Random rnd = new Random(DateTime.Now.Millisecond);
      return rnd.Next();
    }
  }
}
