using System.Collections.Generic;

namespace ExerciseAutoLock {
  public class Car {
    public List<Door> Doors = new List<Door>();
    private double _speed;
    public double Speed {
      get {
        return _speed;
      }
      set {
        _speed = value;
        RaiseSpeedEvent();
      }
    }
    public delegate void SpeedHasChangedHandler(object sender, SpeedEventArgs e);
    public event SpeedHasChangedHandler SpeedEvent;


    public Car(int numberOfDoors) {
      for (int i = 0; i < numberOfDoors; i++) {
        Doors.Add(new Door());
      }
    }

    protected virtual void RaiseSpeedEvent()
    {
      SpeedEvent?.Invoke(this, new SpeedEventArgs(Speed));
    }
  }
}
