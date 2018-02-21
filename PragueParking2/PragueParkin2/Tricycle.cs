using System;

namespace PragueParking2
{
    public class Tricycle : Vehicle
    {
        public Tricycle(string regNr, DateTime arrivalTime) : base(regNr, arrivalTime, 3)
        {

        }
    }

}