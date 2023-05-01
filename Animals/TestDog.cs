using System;

namespace Animals
{
    class TestDog
    {
        static void Main()
        {
            //Dog Xena = new Dog(); // create new dogs
            //Dog Fluffy = new Dog();
            //Dog Toby = new Dog(1, "Labrador", "Black", "Toby");
            //Dog Max = new Dog("Max");

            //Xena.AgeDog = 10;
            //Fluffy.AgeDog = 4;
            //Toby.AgeDog = 2;
            //Max.AgeDog = 15;

            //Xena.KindDog = "Suisse White Shepherd";
            //Fluffy.KindDog = "Poodle";
            //Toby.KindDog = "Labrador";
            //Max.KindDog = "Teckel";

            //Xena.ColorDog = "White";
            //Fluffy.ColorDog = "Brown";
            //Toby.ColorDog = "Gold";
            //Max.ColorDog = "Grey";

            //Xena.NameDog = "Liana of Reckham's Castle";
            //Fluffy.NameDog = "Sjors Des Petits Brugeois";
            //Toby.NameDog = "Toby";
            //Max.NameDog = "Max";

            //Console.WriteLine("Test methods:");
            //Toby.Bark();
            //Xena.Sit();
            //Fluffy.Eat();
            //Max.Bark();

            //Console.WriteLine("\n" + "Test Class Dog:");
            //Console.WriteLine(Xena.NameDog + ", " + Xena.AgeDog + ", " + Xena.KindDog + ", " + Xena.ColorDog + "\n");
            //Console.WriteLine(Fluffy.NameDog + ", " + Fluffy.AgeDog + ", " + Fluffy.KindDog + ", " + Fluffy.ColorDog + "\n");
            //Console.WriteLine(Toby.NameDog + ", " + Toby.AgeDog + ", " + Toby.KindDog + ", " + Toby.ColorDog + "\n");
            //Console.WriteLine(Max.NameDog + ", " + Max.AgeDog + ", " + Max.KindDog + ", " + Max.ColorDog + "\n");

            Chicken white = new Chicken();
            Chicken brown = new Chicken();
            Chicken black = new Chicken();
            Chicken chicken = new Chicken();

            white.NumberofEggsInOneday = -1; // returns 0
            brown.NumberofEggsInOneday = 6; // returns 2
            black.NumberofEggsInOneday = 0; // returns 0


            Console.WriteLine("\n" + "Test 1 Class Chicken:");
            Console.WriteLine(white.NumberofEggsInOneday);
            Console.WriteLine(brown.NumberofEggsInOneday);
            Console.WriteLine(black.NumberofEggsInOneday);
            Console.WriteLine(chicken.NumberofEggsInOneday); // returns default 1

            Console.WriteLine("\n" + "Test 2 Class Chicken:");
            white.NumberofEggsInOneday = 1;
            brown.NumberofEggsInOneday = 2;
            black.NumberofEggsInOneday = 122555555;
            chicken.NumberofEggsInOneday = -1252544;

            Console.WriteLine(white.NumberofEggsInOneday);
            Console.WriteLine(brown.NumberofEggsInOneday);
            Console.WriteLine(black.NumberofEggsInOneday);
            Console.WriteLine(chicken.NumberofEggsInOneday);

            Console.ReadLine();
        }
    }
}

