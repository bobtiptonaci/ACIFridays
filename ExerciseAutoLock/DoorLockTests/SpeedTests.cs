using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseAutoLock;

namespace DoorLockTests {
  [TestClass]
  public class SpeedTests
  {
    private Car _testCar;
    private CarWatcher _watcher;

    [TestInitialize]
    public void TestInit()
    {
      _testCar = new Car(4);
      _watcher = new CarWatcher(_testCar);
    }

    [TestMethod]
    public void DoorLocksWhenAtOrAbove15Mph()
    {
      _testCar.Speed = 25;
      Assert.IsTrue(_testCar.Doors.All(t => t.IsLocked));
    }

    [TestMethod]
    public void DoorIsUnlockedWhenBelow15Mph() {
      _testCar.Speed = 5;
      Assert.IsTrue(_testCar.Doors.All(t => !t.IsLocked));
    }

    [TestMethod]
    public void IfDoorIsAutoLockedRemainsLockedWhenSpeedDrops() {
      _testCar.Speed = 15;
      _testCar.Speed = 5;
      Assert.IsTrue(_testCar.Doors.All(t => t.IsLocked));
    }
  }
}
