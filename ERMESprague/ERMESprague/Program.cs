using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingSchool
{

    /* bil = ABC123
       MC = ABC123:
       MC2 = ABC123:ABC123 */

    class Program
    {
        static string[] arParking = new string[100];

        static void Main(string[] args)
        {

            for (int i = 0; i < arParking.Length; i++)
            {
                arParking[i] = "";
            }

            FillArrayWithVehicles(100);

            for (int i = 0; i < arParking.Length; i++)
            {
                if (i < 9)
                {
                    string posveh = "(" + (i + 1) + ")" + "  " + arParking[i];

                    int spaces = 20 - posveh.Length;
                    string result = new string(' ', spaces);
                    //Console.WriteLine("(" + (i + 1) + ")" + result + arParking[i]);
                    if (i % 5 == 0 && i != 0)
                    {
                        Console.Write("\n");
                    }

                    Console.Write(posveh + result);
                }
                else
                {
                    string posveh = "(" + (i + 1) + ")" + " " + arParking[i];

                    int spaces = 20 - posveh.Length;
                    string result = new string(' ', spaces);
                    //Console.WriteLine("(" + (i + 1) + ")" + result + arParking[i]);
                    if (i % 5 == 0 && i != 0)
                    {
                        Console.Write("\n");
                    }
                    Console.Write(posveh + result);
                }

            }
            Console.WriteLine("\n");

            string choose = "=";

            while (choose != "0")
            {
                Console.WriteLine("\n(1)Add Car \n(2)Add Motorcycle \n(3)Search for your vehicle \n(4)Move Vehicle\n(5)Remove Vehicle\n(6)Show parking\n Write 0 to exit the program!\n");

                choose = (Console.ReadLine());

                if (choose == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Write your cars registration");
                    int spot = AddCar(GetValidReg());
                    if (spot != -1)
                    {
                        Console.Clear();
                        Console.WriteLine("YOUR VEHICLE IS IN SPOT {0}\n", spot + 1);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("YOUR VEHICLE IS ALREADY PARKED HERE!\n");
                    }

                }
                else if (choose == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Write your motorcycles registration");
                    int spot = AddMc(GetValidReg());
                    if (spot != -1)
                    {
                        Console.Clear();
                        Console.WriteLine("YOUR VEHICLE IS IN SPOT {0}\n", spot + 1);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("YOUR VEHICLE IS ALREADY PARKED HERE!\n");
                    }
                }
                else if (choose == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Searching for your vehicle:");
                    int plats = SearchVehicle(GetValidReg());

                    if (plats != -1)
                    {
                        Console.WriteLine("Your vehicle is in spot {0}", plats + 1);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("WE COULD NOT FIND YOUR VEHICLE!");
                    }
                }
                else if (choose == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Moving Vehicle");
                    Console.WriteLine("Write your vehicles registration:");
                    string user = GetValidReg();
                    Console.WriteLine("Write position:");
                    int pos = int.Parse(Console.ReadLine());
                    pos = pos - 1;
                    if (MoveVehicle(user, pos))
                    {
                        Console.Clear();
                        Console.WriteLine("YOUR VEHICLE HAS SUCCESSFULLY BEEN MOVED\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("MOVE IS INVALID\n");
                    }
                }
                else if (choose == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Removing vehicle");
                    Console.WriteLine("Write your vehicles registration:");
                    if (RemoveVehicle(GetValidReg()))
                    {
                        Console.Clear();
                        Console.WriteLine("YOUR VEHICLE HAS SUCCESSFULLY BEEN REMOVED\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("COULD NOT REMOVE YOUR VEHICLE\n");
                    }
                }
                else if (choose == "6")
                {
                    Console.Clear();
                    for (int i = 0; i < arParking.Length; i++)
                    {
                        if (i < 9)
                        {
                            string posveh = "(" + (i + 1) + ")" + "  " + arParking[i];

                            int spaces = 20 - posveh.Length;
                            string result = new string(' ', spaces);
                            if (i % 5 == 0 && i != 0)
                            {
                                Console.Write("\n");
                            }

                            Console.Write(posveh + result);
                        }
                        else
                        {
                            string posveh = "(" + (i + 1) + ")" + " " + arParking[i];

                            int spaces = 20 - posveh.Length;
                            string result = new string(' ', spaces);
                            if (i % 5 == 0 && i != 0)
                            {
                                Console.Write("\n");
                            }
                            Console.Write(posveh + result);
                        }
                    }
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid option\n");
                }
            }

        }

        static string[] GetVehiclesAtPosition(int pos)
        {
            string s = arParking[pos];
            if (s.Length == 0)
                return new string[0];
            if (!s.Contains(':'))
            {
                return new string[] { s };
            }
            if (s.EndsWith(":"))
            {
                return new string[] { s.Replace(":", "") };
            }
            return s.Split(':');
        }

        static bool CheckValidReg(string reg)
        {
            return Regex.IsMatch(reg.ToUpper(), @"^[a-zA-Z0-9]+$");
        }

        static string GetValidReg()
        {
            string reg = ":";
            while (!CheckValidReg(reg))
            {
                reg = Console.ReadLine();
                if (CheckValidReg(reg))
                {
                    return reg.ToUpper();
                }
                else
                {
                    Console.WriteLine("Invalid registration number try again:");
                }
            }
            return reg;
        }

        static void FillArrayWithVehicles(int size)
        {
            Random random = new Random();
            int iNumVehicle = 100;
            for (int i = 0; i < iNumVehicle; i++)
            {
                bool bIsCar = (random.Next(0, 2) == 1) ? true : false;
                int iLen = random.Next(4, 8);

                string strRandRegNo = Path.GetRandomFileName();
                strRandRegNo = strRandRegNo.Substring(0, iLen);
                if (bIsCar)
                    AddCar(strRandRegNo.ToUpper());
                else
                    AddMc(strRandRegNo.ToUpper());
            }
        }

        static bool CheckDuplicate(string reg)
        {
            for (int i = 0; i < arParking.Length; i++)
            {
                string[] tempArray = GetVehiclesAtPosition(i);
                foreach (string s in tempArray)
                {
                    if (reg == s)
                        return true;
                }
            }
            return false;
        }


        static int AddCar(string reg)
        {
            int spot = -1;
            if (CheckDuplicate(reg))
            {
                return spot;
            }
            else
            {
                for (int i = 0; i < arParking.Length; i++)
                {
                    if (arParking[i] == "")
                    {
                        arParking[i] = reg;
                        spot = i;
                        return spot;
                    }
                }
            }
            return spot;
        }

        static bool TryAddMcAtPos(string reg, int pos)
        {
            if (arParking[pos].EndsWith(":"))
            {
                arParking[pos] = arParking[pos] + reg;
                return true;
            }
            else if (arParking[pos] == "")
            {
                arParking[pos] = reg + ":";
                return true;
            }
            return false;
        }

        static int AddMc(string reg)
        {
            int spot = -1;
            if (CheckDuplicate(reg))
            {
                return spot;
            }
            else
            {
                for (int i = 0; i < arParking.Length; i++)
                {
                    if (TryAddMcAtPos(reg, i))
                    {
                        return i;
                    }
                }
            }
            return spot;
        }

        static int SearchVehicle(string reg)
        {
            int spot = -1;
            for (int i = 0; i < arParking.Length; i++)
            {
                string[] temp = GetVehiclesAtPosition(i);
                if (temp.Contains(reg))
                {
                    spot = i;
                    return spot;
                }
            }
            return spot;

        }

        static bool RemoveVehicle(string reg)
        {
            for (int i = 0; i < arParking.Length; i++)
            {
                string[] temp = GetVehiclesAtPosition(i);
                if (temp.Contains(reg))
                {
                    string setValue = "";
                    if (temp.Length > 1)
                    {
                        if (temp[0] == reg)
                        {
                            setValue = temp[1] + ":";
                        }
                        else
                        {
                            setValue = temp[0] + ":";
                        }
                    }

                    arParking[i] = setValue;
                    return true;
                }
            }
            return false;
        }

        static bool MoveVehicle(string reg, int moveto)
        {
            for (int i = 0; i < arParking.Length; i++)
            {
                string[] temparray = GetVehiclesAtPosition(i);


                if (temparray.Contains(reg))
                {
                    bool isMC = arParking[i].Contains(":");
                    RemoveVehicle(reg);
                    if (isMC)
                    {
                        if (TryAddMcAtPos(reg, moveto))
                        {
                            return true;
                        }
                        else
                        {
                            TryAddMcAtPos(reg, i);
                            return false;
                        }
                    }
                    else
                    {
                        if (arParking[moveto].Length == 0)
                        {
                            arParking[moveto] = reg;
                            return true;
                        }
                        else
                        {
                            arParking[i] = reg;
                            return false;
                        }
                    }
                }
            }
            return false;
        }
    }
}