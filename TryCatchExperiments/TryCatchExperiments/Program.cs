using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExperiments {
  class Program {
    static void Main(string[] args) {
      try {
        Exception1();
        int zero = 0;
        int i = 4 / zero;

      }
      catch (Exception e) {
        Console.WriteLine("Exception caught in main: " + e.Message);
      }

      try {
        int z = 3;
        if (z == 3) throw new MonkeyException("Monkey in main", null);
      }

      catch (Exception e) {
        Console.WriteLine("Exception caught in main part 2: " + e.Message);
      }

      try {
        RethrownException();
      }
      catch (Exception e) {
        Console.WriteLine("Rethrown from main: " + e.Message);
        Console.WriteLine("Rethrown inner: " + e.InnerException.Message);
      }
      Console.ReadLine();

    }

    public static void Exception1() {
      try {
        throw new SystemException();
      }
      catch (Exception e) {
        Console.WriteLine("Problem 1 exception caught: " + e.Message);
      }
    }

    public static void RethrownException() {
      try {
        throw new SystemException("SystemException in Rethrown");
      } 
      catch (Exception e) {
        Console.WriteLine("Exception thrown in RethrownException");
        MonkeyException newException = new MonkeyException("Rethrown monkey", e);
        throw newException;
      }
    }
  }

  public class MonkeyException : SystemException {
    public MonkeyException(string message, Exception innerException) : base(message, innerException) {

    }
    //public override string Message {
    //  get {
    //    return "Monkey!";
    //  }
    //}
  }
}
