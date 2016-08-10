using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  class Program {
    static void Main(string[] args) {
      List<MyBase> bases = new List<MyBase>();
      bases.Add(new MyDerived1());
      bases.Add(new MyDerived2());
      bases.Add(new MyDerived3());

      Console.WriteLine("Using var...");
      foreach (var item in bases) {
        Compile(item);
      }

      Console.WriteLine("\nUsing dynamic...");
      foreach (dynamic item in bases) {
        Compile(item);
      }

      Console.WriteLine("\nUsing object...");
      foreach (object item in bases) {
        Compile(item);
      }

      Console.ReadLine();
    }

    static void Compile(object myobject) {
      Console.WriteLine("Object compile");
    }

    static void Compile(MyBase mybase) {
      Console.WriteLine("Base Compile");
    }

    static void Compile(MyDerived1 myderived) {
      Console.WriteLine("Derived1 compile");
    }
    static void Compile(MyDerived2 myderived) {
      Console.WriteLine("Derived2 compile");
    }
    public abstract class MyBase { }
    public class MyDerived1 : MyBase { }
    public class MyDerived2 : MyBase { }
    public class MyDerived3 : MyBase { }
  }


}
