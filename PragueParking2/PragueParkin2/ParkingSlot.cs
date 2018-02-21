using System;
using System.Collections;
using System.Collections.Generic;

namespace PragueParking2
{

    public class ParkingSlot
    {

        public const int size = 4;

        public int freeSize = 4;

        private List<Vehicle> vehicles = new List<Vehicle>();

        public void add(Vehicle vehicle)
        {
            if (vehicle.size <= freeSize)
            {
                vehicles.Add(vehicle);
                freeSize -= vehicle.size;
            }
        }
        public void remove(Vehicle vehicle)
        {
            Vehicle tmp = search(vehicle.regNr);
            if (tmp != null)
            {
                vehicles.Remove(tmp);
                freeSize += vehicle.size;
            }
        }

        public Vehicle search(string regNr)
        {
            Vehicle tmp = null;
            foreach (Vehicle aVehicle in vehicles)
            {
                if (aVehicle.regNr == regNr)
                {
                    tmp = aVehicle;
                    break;
                }
            }
            return tmp;
        }

        public string content()
        {
            string str = "";

            if (freeSize == size)
            {
                str += "|      :      :      :      |";
            }
            else if (freeSize == 0)
            {
                if (vehicles.Count == 1)
                {
                    str += "|          " + vehicles[0].regNr + "           |";
                }
                else if (vehicles.Count == 2)
                {
                    str += "|    " + vehicles[0].regNr + "   :    " +  vehicles[1].regNr + "   |";
                }
                else if (vehicles.Count == 3)
                {
                    str += "|  " + vehicles[0].regNr + " : " + vehicles[1].regNr + " : " + vehicles[2].regNr + " |";
                }
                else if (vehicles.Count == 4)
                {
                    str += "| " + vehicles[0].regNr + ":" + vehicles[1].regNr + ":" + vehicles[2].regNr + ":" + vehicles[3].regNr + "|";
                }
            }
            else {
                if (vehicles.Count == 1)
                {
                    if (vehicles[0].size == 3)
                    {
                        str += "|       " + vehicles[0].regNr + "       :      |";
                    }
                    else if (vehicles[0].size == 2)
                    {
                        str += "|   " + vehicles[0].regNr + "    :      :      |";
                    }
                    else if (vehicles[0].size == 1)
                    {
                        str += "|" + vehicles[0].regNr + ":      :      :      |";
                    }
                }
                if (vehicles.Count == 2)
                {
                    if (vehicles[0].size == 2)
                    {
                        str += "|    " + vehicles[0].regNr + "   :" + vehicles[1].regNr + ":      |";
                    }
                    else if (vehicles[1].size == 2)
                    {
                        str += "|" + vehicles[0].regNr + ":    " + vehicles[1].regNr + "   :      |";
                    }
                    else {
                        str += "|" + vehicles[0].regNr + ":" + vehicles[1].regNr + ":      :      |";
                    }
                }
                else if (vehicles.Count == 3)
                {
                    str += "|" + vehicles[0].regNr + ":" + vehicles[1].regNr + ":" + vehicles[2].regNr + ":      |";
                }
            }
            return str;
        }

    }

}