using System;

namespace PragueParking2 {
    public abstract class Vehicle {

        public string regNr;
        public int size;
        public DateTime arrivalTime;

        public Vehicle(string regNr, DateTime arrivalTime, int size) {
            this.regNr = regNr;
            this.size = size;
            this.arrivalTime = arrivalTime;
        }

    }
}