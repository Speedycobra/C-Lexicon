using System;

namespace PragueParking2 {
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string regNr, DateTime arrivalTime, int size) : base(regNr, arrivalTime, size)
        {
            this.size = 2;
        }
    }

}