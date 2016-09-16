using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWithIObservable {
  public class Car : IObservable<int> {
    List<IObserver<int>> carWatchers = new List<IObserver<int>>();

    private int speed;

    public int Speed {
      get { return speed; }
      set {
        speed = value;
        foreach (var watcher in carWatchers) {
          watcher.OnNext(value);
        }
      }
    }

    public IDisposable Subscribe(IObserver<int> observer) {
      // Add the observer if isn't already in the observers list
      if (!carWatchers.Contains(observer)) {
        carWatchers.Add(observer);
      }

      // Unsubscriber is used by the observer to manually unsubscribe iteself
      return new CarUnsubscriber(this, observer);
    }
  }
}
