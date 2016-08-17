namespace ExerciseAutoLock {

  public class Door {
    public bool IsLocked { get; set; }
    public void Lock() {
      IsLocked = true;
    }
  }
}
