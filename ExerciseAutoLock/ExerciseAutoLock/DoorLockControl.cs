using System;
using System.Collections.Generic;

namespace ExerciseAutoLock {
  public static class DoorLockControl {
    public static void CheckLockState(double speed, List<Door> doors)
    {
      if (doors == null) throw new ArgumentNullException(nameof(doors));
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
