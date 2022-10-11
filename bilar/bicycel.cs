using System;
using System.Collections.Generic;
using System.Text;

namespace bilar
{
    class bicycel:IVehicle
    {

        public int changeGear(int a) 
        {

            Console.WriteLine("Gear changed");
            a = 2;
            return a;
        
        }
        public int speedUp(int speed) 
        {

            speed += 1;
            return speed;
        
        }
        public void applyBrakes()
        {
            Console.WriteLine("Bilen har stannat");
        
        }

    }
}
