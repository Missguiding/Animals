using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
  class Dog
  {
    private static int _intDogCounter = 0;  // static field because we count on class level

    public int AgeDog { get; set; }// automatic property        

    public string KindDog { get; set; }// automatic property       

    public string ColorDog { get; set; }// automatic property        

    public string NameDog { get; set; } // automatic property

    public int CountDog { get; private set; } // property read only

    public Dog() // constructor with no parameters
    {
      DogCounter(); // using method to count dogs
    }

    public Dog(string strName) : this()// constructor with one proporty use and so also using the method to count dogs
    {
      NameDog = strName;
    }

    public Dog(int intAge, string strKind, string strColor, string strName) : this(strName) // constructor with all proporty use using Dog(strName)
    {
      AgeDog = intAge;
      KindDog = strKind;
      ColorDog = strColor;
    }


    public void Bark() // method
    {
      Console.WriteLine("WoefWoef");
      Console.Beep();
    }

    public void Sit() // method 
    {
      Console.WriteLine("Sit");
    }

    public void Eat() // method
    {
      Console.WriteLine("Eat your meal");
    }

    private void DogCounter() // method only in class usable
    {
      _intDogCounter++; // add one 
      CountDog = _intDogCounter;
    }

    class TestDog
    {
      static void Main()
      {
        Dog Xena = new Dog(); // create new dogs
        Dog Fluffy = new Dog();
        Dog Toby = new Dog(1, "Labrador", "Black", "Toby");
        Dog Max = new Dog("Max");

        // VVDW Hier moet countdog al 4 zijn.

        Xena.AgeDog = 10;
        Fluffy.AgeDog = 4;
        Toby.AgeDog = 2;
        Max.AgeDog = 15;


        Xena.KindDog = "Suisse White Shepherd";
        Fluffy.KindDog = "Poodle";
        Toby.KindDog = "Labrador";
        Max.KindDog = "Teckel";

        Xena.ColorDog = "White";
        Fluffy.ColorDog = "Brown";
        Toby.ColorDog = "Gold";
        Max.ColorDog = "Grey";

        Xena.NameDog = "Liana of Reckham's Castle";
        Fluffy.NameDog = "Sjors Des Petits Brugeois";
        Toby.NameDog = "Toby";
        Max.NameDog = "Max";

        Console.WriteLine("Test methods:");
        Toby.Bark();
        Xena.Sit();
        Fluffy.Eat();
        Max.Bark();

        Console.WriteLine("\n" + "Test Class:");
        Console.WriteLine(Xena.NameDog + ", " + Xena.AgeDog + ", " + Xena.KindDog + ", " + Xena.ColorDog + "\n");
        Console.WriteLine(Fluffy.NameDog + ", " + Fluffy.AgeDog + ", " + Fluffy.KindDog + ", " + Fluffy.ColorDog + "\n");
        Console.WriteLine(Toby.NameDog + ", " + Toby.AgeDog + ", " + Toby.KindDog + ", " + Toby.ColorDog + "\n");
        Console.WriteLine(Max.NameDog + ", " + Max.AgeDog + ", " + Max.KindDog + ", " + Max.ColorDog + "\n");

        Console.WriteLine("\n" + "Test Counting Dog:");
        Console.WriteLine(Xena.CountDog);
        Console.WriteLine(Max.CountDog);
        Console.WriteLine(Toby.CountDog);
        Console.WriteLine(Fluffy.CountDog);
        Console.WriteLine(Fluffy.CountDog);

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Check :-)");
        Console.ReadLine();
      }
    }
  }
}
