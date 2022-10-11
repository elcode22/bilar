using System;

namespace bilar
{
    interface IVehicle
    {

        int changeGear(int a);
        int speedUp(int speed);
        void applyBrakes();

    }
    class Program
    {
        static void Main(string[] args)
        {
            bicycel b = new bicycel();
            bike B = new bike();

            b.changeGear(0);
            b.speedUp(10);
            b.applyBrakes();

            B.changeGear(0);
            B.speedUp(10);
            B.applyBrakes();

            Console.WriteLine("Bicycle present state : " + b.changeGear(0) +"\n"+ b.speedUp(10));
            Console.WriteLine("Bike present state : " + B.changeGear(0) +"\n"+ B.speedUp(12));
        }
    }
}
