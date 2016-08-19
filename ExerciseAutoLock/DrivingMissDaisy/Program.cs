using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseAutoLock;

namespace DrivingMissDaisy {
  class Program {
    static void Main(string[] args) {
      Car myCar = new Car(5);
      CarWatcher watcher = new CarWatcher(myCar);

      List<double> speeds = new List<double> { 0.0, 5.0, 10.0, 14.0, 16.0, 50.0, 80.0, 0.0 };
      do
      {
        foreach (var speed in speeds)
        {
          Console.WriteLine("Setting speed to {0} mph...", speed);
          myCar.Speed = speed;
          DisplayCarStatus(myCar);
          System.Threading.Thread.Sleep(2000);
        }

      } while (true);
    }

    private static void DisplayCarStatus(Car car)
    {
      Console.Write("Doors state: ");
      foreach (var door in car.Doors) {
        Console.Write(door.IsLocked ? "L" : "U");
      }
      Console.Write("\r\n");
    }
  }
}
