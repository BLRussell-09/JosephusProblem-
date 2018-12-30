using System;
using System.Collections.Generic;

namespace JosephusProblem
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> numberBay = new List<int>() {1,2,3,4,5,6,7,8,9,10};

      listCrunch(numberBay);

      Console.Read();
    }

    static bool listCrunch(List<int> numberBay)
    {
      int dexBump = 0;
      int dexStart = 1;

      while (numberBay.Count > 2)
      {
        var listLength = numberBay.Count;
        List<int> dropDex = new List<int>();

        dexFindr(dexStart, dexBump, numberBay, dropDex);

        dexCrusher(dropDex, numberBay);

        Console.WriteLine();

        foreach (int number in numberBay)
        {
          Console.Write(number + ",");
        }

        dexBump = listLength % 3 + dexStart;
        dexStart = 0;
      }

      return true;
    }

    static List<int> dexFindr(int dexStart, int dexBump, List<int> numberBay, List<int> dropDex)
    {
      var listLength = numberBay.Count;
      for (int idx = dexStart; idx <= numberBay.Count; idx++)
      {
        if (idx % 3 == 0)
        {
          if ((idx - 1 + dexBump) < listLength)
          {
            dropDex.Add(idx - 1 + dexBump);
          }
        }
      }

      dropDex.Reverse();
      return dropDex;
    }

    static List<int> dexCrusher(List<int> dropDex, List<int> numberBay)
    {
      foreach (int number in dropDex)
      {
        numberBay.RemoveAt(number);
      } 

      return numberBay;
    }


  }
}
