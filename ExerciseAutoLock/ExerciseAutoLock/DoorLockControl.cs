using System.Collections.Generic;

namespace ExerciseAutoLock {
  public static class DoorLockControl {
    public static void CheckLockState(double speed, List<Door> doors) {
      foreach (var door in doors) {
        if (SpeedLimitReached(speed))
          door.Lock();
      }
    }
    private static bool SpeedLimitReached(double speed) {
      return speed >= 15.0;
    }
  }
}
