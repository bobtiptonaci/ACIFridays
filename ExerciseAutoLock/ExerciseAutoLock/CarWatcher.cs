﻿namespace ExerciseAutoLock {
  public class CarWatcher {
    private Car myCar;
    public CarWatcher(Car car) {
      myCar = car;
      myCar.SpeedEvent += HandleSpeedEvent;
    }

    public void HandleSpeedEvent(object sender, SpeedEventArgs e) {
      if (!(sender is Car)) return;
      var car = (Car)sender;
      CheckSpeed(e.Speed, car);
    }

    private static void CheckSpeed(double speed, Car car) {
      DoorLockControl.CheckLockState(speed: speed, doors: car.Doors);
      Speedometer.UpdateSpeed(speed: speed);
    }
  }
}
