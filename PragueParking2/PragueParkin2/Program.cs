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

            Bicycle bic2 = new Bicycle("BIC666", DateTime.Now);
            parking.add(bic2);

            Bicycle bic3 = new Bicycle("BIC888", DateTime.Now);
            parking.add(bic3);

            Bicycle bic4 = new Bicycle("BIC999", DateTime.Now);
            parking.add(bic4);

            //parking.printParking();
            PrintState(parking);
            Console.ReadLine();

        }
        static void PrintState(ParkingLot p)
        {
            int index = 0;
            string[] parking = p.Content();
            for (int i = 0; i < 50; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    //  Console.ForegroundColor = ConsoleColor.White;
                    Console.CursorLeft = x * 50;
                    if (index < 9) Console.Write(" ");
                    if (index < 99) Console.Write(" ");
                    if (parking[index].Equals(""))
                        Console.Write("{0}: [Spot Empty]", index + 1);
                    if (!parking[index].Equals(""))
                        Console.Write("{0}: {1} ", index + 1, parking[index].ToString());

                    index++;
                }
                Console.WriteLine();
            }
        }
    }
}
