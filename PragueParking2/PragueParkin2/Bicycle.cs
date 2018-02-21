using System;

namespace PragueParking2
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string regNr, DateTime arrivalTime) : base(regNr, arrivalTime, 1)
        {

        }
    }

}