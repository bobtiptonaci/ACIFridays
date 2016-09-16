using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWithIObservable {
  public class CarSpeedWatcher : IObserver<int> {
    public void OnCompleted() {
      throw new NotImplementedException();
    }

    public void OnError(Exception error) {
      throw new NotImplementedException();
    }

    public void OnNext(int value) {
      throw new NotImplementedException();
    }
  }
}
