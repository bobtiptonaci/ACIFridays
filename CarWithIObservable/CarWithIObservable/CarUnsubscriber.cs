using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWithIObservable {
  public class CarUnsubscriber : IDisposable {
    IObservable<int> car;
    IObserver<int> watcher;

    public CarUnsubscriber(IObservable<int> carObservable, IObserver<int> carWatcher) {
      car = carObservable;
      watcher = carWatcher;
    }

    public void Dispose() {
      car = null;
      watcher = null;
    }
  }
}
