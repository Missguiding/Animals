using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TestChicken
    {
    static void Main()
    {
      // VVDW - Changed all
      Chicken white = new Chicken();
      Chicken brown = new Chicken();
      Chicken black = new Chicken();
      Chicken chicken = new Chicken();

      white.NumberofEggsInOneday = -1; // returns 0
      brown.NumberofEggsInOneday = 6; // returns 2
      black.NumberofEggsInOneday = 0; // returns 0

      Console.WriteLine("\n" + "Test Class Chicken:");
      white.HowManyEggs();
      brown.HowManyEggs();
      black.HowManyEggs();
      chicken.HowManyEggs();

      Console.WriteLine("\n" + "Test 2 Class Chicken:");
      white.NumberofEggsInOneday = 1;
      brown.NumberofEggsInOneday = 2;
      black.NumberofEggsInOneday = 122555555;
      chicken.NumberofEggsInOneday = -1252544;

      white.HowManyEggs();
      brown.HowManyEggs();
      black.HowManyEggs();
      chicken.HowManyEggs();

      Console.ReadLine();
    }
  }
}
