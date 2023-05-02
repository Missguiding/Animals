using System;

namespace Animals
{
  class TestDog
  {
    static void Main()
    {
      Dog Xena = new Dog(); // create new dogs
      Dog Fluffy = new Dog();
      Dog Toby = new Dog(1, "Labrador", "Black", "Toby");
      Dog Max = new Dog("Max");

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

      Console.WriteLine("\n" + "Test Class Dog:");
      Console.WriteLine(Xena.NameDog + ", " + Xena.AgeDog + ", " + Xena.KindDog + ", " + Xena.ColorDog + "\n");
      Console.WriteLine(Fluffy.NameDog + ", " + Fluffy.AgeDog + ", " + Fluffy.KindDog + ", " + Fluffy.ColorDog + "\n");
      Console.WriteLine(Toby.NameDog + ", " + Toby.AgeDog + ", " + Toby.KindDog + ", " + Toby.ColorDog + "\n");
      Console.WriteLine(Max.NameDog + ", " + Max.AgeDog + ", " + Max.KindDog + ", " + Max.ColorDog + "\n");

    }
  }
}

