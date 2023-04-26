using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
  class Dog
  {
    public int _intAgeDog; // fields
    public string _strKindDog;
    public string _strColorDog;
    public string _strNameDog;

    public int AgeDog // property
    {
      get
      {
        if (_intAgeDog > 8)
        {
          Sit(_strNameDog); // if dog is older then 8, let hem sit
        }
        return _intAgeDog;
      }
      set
      {
        _intAgeDog = value;
      }

    }

    public string KindDog // property
    {
      get
      {
        Eat();
        return _strKindDog;
      }
      set
      {
        _strKindDog = value;
      }

    }

    public string ColorDog // property
    {
      get
      {
        return _strColorDog;
      }
      set
      {
        _strColorDog = value;
      }

    }

    public string NameDog // property
    {
      get
      {

        Bark(); // let every dog bark
        return _strNameDog;
      }
      set
      {
        _strNameDog = value;
      }

    }

    public Dog() // constructor with no parameters
    {

    }

    public Dog(string strName) : this() // constructor with one proporty use
    {
      NameDog = strName;

    }

    public Dog(int intAge, string strKind, string strColor, string strName) : this() // constructor with all proporty use
    {
      AgeDog = intAge;
      KindDog = strKind;
      ColorDog = strColor;
      NameDog = strName;

    }

    static void Bark() // method with variable
    {
      string _strBark = "WoefWoef";

      Console.WriteLine(_strBark);
      Console.Beep();
    }

    static void Sit(string _strName) // method with parameter
    {
      Console.WriteLine("Sit, {0} sit", _strName);
    }

    static void Eat() // method
    {
      Console.WriteLine("Eat your meal");
    }

    public static int intDogCounter;

    public static int CountDog // proporty read only
    {
      get
      {
        return intDogCounter++;
      }
    }
  }


  class TestDog
  {
    static void Main(string[] args)
    {
      Dog Xena = new Dog();
      Dog Fluffy = new Dog();
      Dog Toby = new Dog(1, "Labrador", "Black", "Toby");
      Dog Max = new Dog("Max");

      Xena.AgeDog = 10;
      Fluffy.AgeDog = 4;
      Max.AgeDog = 15;

      Xena.KindDog = "Suisse White Shepherd";
      Fluffy.KindDog = "Poodle";
      Max.KindDog = "Teckel";

      Xena.ColorDog = "White";
      Fluffy.ColorDog = "Brown";
      Max.ColorDog = "Grey";

      Xena.NameDog = "Liana of Reckham's Castle";
      Fluffy.NameDog = "Sjors Des Petits Brugeois";


      Console.WriteLine(Xena.NameDog + ", " + Xena.AgeDog + ", " + Xena.KindDog + ", " + Xena.ColorDog + "\n", Dog.CountDog);
      Console.WriteLine(Fluffy.NameDog + ", " + Fluffy.AgeDog + ", " + Fluffy.KindDog + ", " + Fluffy.ColorDog + "\n", Dog.CountDog);
      Console.WriteLine(Toby.NameDog + ", " + Toby.AgeDog + ", " + Toby.KindDog + ", " + Toby.ColorDog + "\n", Dog.CountDog);
      Console.WriteLine(Max.NameDog + ", " + Max.AgeDog + ", " + Max.KindDog + ", " + Max.ColorDog + "\n", Dog.CountDog);
      Console.WriteLine(Dog.CountDog);
      Console.WriteLine(Dog.CountDog); // VVDW
      Console.ReadLine();
    }
  }
}
