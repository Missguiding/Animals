using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Chicken
    {
        private int _intEggsInOneDay; // field

        public int NumberofEggsInOneday // property

        {
            get
            {

                if (_intEggsInOneDay < 0) 
                {
                    _intEggsInOneDay = 0;

                }
                else if (_intEggsInOneDay > 2)
                {
                    _intEggsInOneDay = 2;
                }

                // HowManyEggs(); // use method - VVDW placed in comment

                return _intEggsInOneDay;
            }
            set
            {
                _intEggsInOneDay = value;
            }
        }

        public Chicken() // proporty with default 1
        {
            NumberofEggsInOneday = 1;
        }
        public void HowManyEggs() // method
        // VVDW Changed private into public
        {
            Console.WriteLine("This chicken can lay so many eggs a day: {0}", NumberofEggsInOneday);
        }
    }
}


