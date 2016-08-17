namespace ExerciseAutoLock {
  public class CarWatcher {
    private Car myCar;
    public CarWatcher(Car car) {
      myCar = car;
      myCar.SpeedEvent += HandleSpeedEvent;
    }

    public void HandleSpeedEvent(object sender, SpeedEventArgs e) {
      if (sender is Car) {
        Car car = (Car)sender;
        CheckSpeed(e.Speed, car);
      }
    }

    private void CheckSpeed(double speed, Car car) {
      DoorLockControl.CheckLockState(speed, car.Doors);
    }
  }
}
