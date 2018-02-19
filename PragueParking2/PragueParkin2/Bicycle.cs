using System;

namespace PragueParking2 {
    public class Bicycle : Vehicle
    {
        public Bicycle(string regNr, DateTime arrivalTime, int size) : base(regNr, arrivalTime, size)
        {
            this.size = 1;
        }
    }

}