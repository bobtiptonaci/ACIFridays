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

      // var evaluates the type at compile time, so it will only see
      // item as a type "MyBase"
      Console.WriteLine("Using var...");
      foreach (var item in bases) {
        Compile(item);
      }

      // dynamic evaluates the type at run time, so it will see
      // the type of each item as what it actually is, i.e., "MyDerived1", "MyDerived2"
      // since we don't have an overload of Compile for MyDerived3, when we hit
      // an item of that type, it will call the overload for MyBase, since every
      // MyDerived3 is also a MyBase.  If we didn't have an overload for MyBase
      // it will call the Object overload of Compile, since every class is also
      // an Object.  If we didn't have the Object overload, we'd get an exception
      Console.WriteLine("\nUsing dynamic...");
      foreach (dynamic item in bases) {
        Compile(item);
      }

      // since we're specifying the type, we'll only ever run the Object overload
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
