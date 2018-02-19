using System;

namespace PragueParking2 {
    public class Tricycle : Vehicle
    {
        public Tricycle(string regNr, DateTime arrivalTime, int size) : base(regNr, arrivalTime, size)
        {
            this.size = 3;
        }
    }

}