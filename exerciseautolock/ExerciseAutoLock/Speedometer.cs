using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAutoLock {
  public static class Speedometer {
    public static void UpdateSpeed(double speed)
    {
      Console.WriteLine("Speed is {0} mph", speed);
      if (speed > 70) Console.WriteLine("Slow down!");
    }
  }
}
