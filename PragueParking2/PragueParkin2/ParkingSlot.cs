using System;
using System.Collections;
using System.Collections.Generic;

namespace PragueParking2 {

    public class ParkingSlot {

        public const int size = 4;

        public int freeSize = 4;

        private List<Vehicle> vehicles = new List<Vehicle>();

        public void add(Vehicle vehicle) {
            if (vehicle.size <= freeSize) {
                vehicles.Add(vehicle);
                freeSize -= vehicle.size;
            }
        }
        public void remove(Vehicle vehicle) {
            Vehicle tmp = search(vehicle.regNr);
            if (tmp != null) {
                vehicles.Remove(tmp);
                freeSize += vehicle.size;
            }
        }

        public Vehicle search(string regNr) {
            Vehicle tmp = null;
            foreach (Vehicle aVehicle in vehicles) {
                if (aVehicle.regNr == regNr) {
                    tmp = aVehicle;
                    break;
                }
            }
            return tmp;
        }

        public string content() {
            return "";
        }


        // public int availableSize() {
        //     int usedSize = 0;
        //     foreach (Vehicle vehicle in vehicles) {
        //         usedSize += vehicle.size;
        //     }
        //     return size - usedSize;
        // }

    }

}