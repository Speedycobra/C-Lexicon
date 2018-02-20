using System;

namespace PragueParking2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Prague Parking 2.0!");

            ParkingLot parking = new ParkingLot();

            Car car1 = new Car("CAR111", DateTime.Now);
            parking.add(car1);

            Motorcycle mot1 = new Motorcycle("MOT111", DateTime.Now);
            parking.add(mot1);
            Motorcycle mot2 = new Motorcycle("MOT222", DateTime.Now);
            parking.add(mot2);
            
            Motorcycle mot3 = new Motorcycle("MOT333", DateTime.Now);
            parking.add(mot3);
            
            Bicycle bic1 = new Bicycle("BIC333", DateTime.Now);
            parking.add(bic1);

            Car car2 = new Car("CAR222", DateTime.Now);
            parking.add(car2);

            Tricycle tri1 = new Tricycle("TRI111", DateTime.Now);
            parking.add(tri1);

            Motorcycle mot4 = new Motorcycle("MOT444", DateTime.Now);
            parking.add(mot4);

            parking.printParking();
            Console.ReadLine();

        }
    }
}
