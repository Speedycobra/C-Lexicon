using System;
using System.Collections;
using System.Collections.Generic;

namespace PragueParking2
{

    public class ParkingLot
    {

        const int parkingSize = 100;

        public ParkingSlot[] slots = new ParkingSlot[parkingSize];

        public int numFreeSlots;

        private int numFreeSizeUnits;

        public ParkingLot()
        {
            for (int i = 0; i < parkingSize; i++)
            {
                slots[i] = new ParkingSlot();
            }
        }

        public Boolean add(Vehicle vehicle)
        {
            Boolean addedVehicle = false;
            for (int i = 0; i < parkingSize; i++) 
            {
                ParkingSlot slot = slots[i];
                if (vehicle.size <= slot.freeSize)
                {
                    slot.add(vehicle);
                    addedVehicle = true;
                    break;
                }
            }
            return addedVehicle;
        }

        public Boolean remove(Vehicle vehicle)
        {
            Boolean removed = false;
            for (int i = 0; i < parkingSize; i++) 
            {
                ParkingSlot slot = slots[i];
                Vehicle tmp = slot.search(vehicle.regNr);
                if (tmp != null)
                {
                    slot.remove(tmp);
                    removed = true;
                }
            }
            return removed;
        }

        public Vehicle search(string regNr)
        {
            Vehicle tmp = null;
            for (int i = 0; i < parkingSize; i++) 
            {
                ParkingSlot slot = slots[i];
                tmp = slot.search(regNr);
                if (tmp != null)
                {
                    return tmp;
                }
            }
            return tmp;
        }

        public void move()
        {

        }

        public string[] Content()
        {
           
                string[] allSlot = new string[parkingSize];
                for (int i = 0; i < parkingSize; i++)
                {
                    allSlot[i] = slots[i].Content();
                }
                return allSlot;
           
        }

        public void optimize()
        {

        }

        public void printParking()
        {

            for (int i = 0; i < parkingSize; i++)
            {
                ParkingSlot slot = slots[i];

                // for better display
                string spotNumberStr = "";
                if (i < 10) {
                    spotNumberStr = "0" + i;
                }
                else{
                    spotNumberStr = "" + i;
                }

                // go to new line on every 9 spots
                if (i % 5 == 0) {
                    if (i != 0) Console.WriteLine();
                    for (int j = 0; j < 5; j++) Console.Write("-------------------------------");
                    Console.WriteLine();
                }

                Console.Write(spotNumberStr + slot.content());

                if (i == 99) {
                    Console.WriteLine();
                    for (int j = 0; j < 5; j++) Console.Write("-------------------------------");
                }
            }
        }

    }
}