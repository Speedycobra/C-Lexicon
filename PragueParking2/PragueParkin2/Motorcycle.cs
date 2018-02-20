using System;

namespace PragueParking2 {
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string regNr, DateTime arrivalTime) : base(regNr, arrivalTime, 2)
        {
            
        }
    }

}