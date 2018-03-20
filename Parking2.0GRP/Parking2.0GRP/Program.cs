using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2._0GRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Welcome to Prague Parking2,0!";
            ParkingLot parking = new ParkingLot();
            while (true)
            {
                PrintState(parking);
                if (Meny(parking))
                    break;      
                Console.Clear();
                
            }
        }

        static public bool Meny(ParkingLot park)
        {
            Console.ForegroundColor = ConsoleColor.White;            
            Console.WriteLine("Choose one");
            Console.WriteLine("1. ADD\t\t2. REMOVE\t3. SEARCH\t4. MOVE\t\t5. Exit");
       
            int userChoice = IntputStrToInt(); //Int32.Parse(Console.ReadLine());
            int place;
            string regNr, input;
            Console.Clear();
            PrintState(park);
            switch (userChoice)
            {
                case 1://ADD
                    {
                        Vehicle vec;
                        Console.WriteLine("Choose the vehicle type you wish to park:");
                        Console.WriteLine("1. CAR\t2. MC\t3. TRIKE\t4. BIKE");
                        
                        int userInput;
                        userInput = IntputStrToInt();

                        Console.WriteLine("Enter registernumber:");
                        regNr = Console.ReadLine().ToUpper();
                        Console.Clear();
                        switch (userInput)
                        {
                            case 1:
                                {                                    
                                    vec = new Car(regNr);
                                    place = park.Add(vec);                                   
                                    PrintText("Put the Car into place: " + (place + 1));
                                    break;
                                }   
                                
                            case 2:
                                {                                    
                                    vec = new MC(regNr);
                                    place = park.Add(vec);
                                    PrintText("Put the MC into place: "+ (place + 1));
                                    break;
                                }
                            case 3:
                                {                                    
                                    vec = new Trike(regNr);
                                    place = park.Add(vec);
                                    PrintText("Put the Trike into place: "+ (place + 1));
                                    break;
                                }
                            case 4:
                                {                                   
                                    vec = new Bike(regNr);
                                    place = park.Add(vec);
                                    PrintText("Put the Bike into place: "+( place + 1));
                                    break;
                                }
                            default:
                                Console.WriteLine("Enter number between 1 to 4!!");
                                break;
                        }
                        break;
                    }
                case 2://REMOVE
                    {
                        Console.WriteLine("Enter registernumber:");
                        regNr = Console.ReadLine().ToUpper();
                        Console.Clear();
                        PrintText(park.Remove(regNr) );
                        break;
                    }
                case 3://SEARCH
                    {
                        Console.WriteLine("Enter registernumber:");
                        regNr = Console.ReadLine().ToUpper();
                        place = park.Search(regNr);
                        Console.Clear();
                        if (place < 0)
                            PrintText("Can´t find the vehicle");
                        else
                            PrintText("The vehicle is in slot: "+( place +1));
                        break;
                    }             
                case 4://MOVE
                    {
                        Console.WriteLine("Enter registernumber:");
                        regNr = Console.ReadLine().ToUpper();
                        Console.WriteLine("Where do you want to put the vehicle?");
                        int slot =int.Parse(Console.ReadLine());
                        Console.Clear();
                        bool b = park.Move(regNr, slot-1);
                        if (b) PrintText("Moved to spot "+( slot));
                        else PrintText("Can't move vehicle");                        
                        break;
                    }          
                case 5://EXIT
                    {
                        Console.WriteLine("Are you sure you want to exit the program? (Y/N)");
                        input = Console.ReadLine().ToUpper();
                        if (input == "Y")
                        {
                            PrintText("Goodbye!");
                            Console.ReadLine();
                            userChoice = -1;
                            Console.Clear();                         
                        }
                        return true;                                             
                    }
                default:
                    {
                        Console.WriteLine("Enter number between 1 to 5!!");
                        break;
                    }
            }           
            return false;
        }

        static public int IntputStrToInt()
        {
            int tal = 0;
            while (tal > -1)
            {
                if(int.TryParse(Console.ReadLine(), out tal))
                {
                    return tal;                    
                }else
                    Console.WriteLine("You type wrong!! Need a number!!!");
            }
            return tal;
        }
              
        static void PrintText(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(30, 30);            
            Console.WriteLine(text);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorSize = 3;
            Console.ReadLine();
        }
        static void PrintState(ParkingLot p)
        {
            int index = 0;
            string[] parking = p.Content();
           
            for (int i = 0; i < 25; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.CursorLeft = x * 40;
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
            Console.WriteLine();
            Console.CursorLeft = 45;
            Console.WriteLine("Welcome to Prague Parking2,0!");
        }   
    }
}
        