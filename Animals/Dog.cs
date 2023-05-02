using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
  class Dog
  {
    static int _intDogCounter = 0; // static field because we count on class level

    public int AgeDog { get; set; } // automatic property        

    public string KindDog { get; set; } // automatic property       

    public string ColorDog { get; set; } // automatic property        

    public string NameDog { get; set; } // automatic property

    public static int CountDog // property read only, part of the class dog only
    {
      get
      {
        return _intDogCounter;
      }
    }


    public Dog() // constructor with no parameters
    {

      Console.WriteLine("Amount of dogs maid:" + "\n" + DogCounter() + "\n"); // using method to count dogs
    }

    public Dog(string strName) : this() // constructor with one property use and so also using the method to count dogs
    {
      NameDog = strName;
    }

    public Dog(int intAge, string strKind, string strColor, string strName) : this(strName) // constructor with all property use using Dog(strName)
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

    private int DogCounter() // method only in class usable
    {

      _intDogCounter = _intDogCounter + 1; // add one 

      return _intDogCounter;
    }
  }
}

