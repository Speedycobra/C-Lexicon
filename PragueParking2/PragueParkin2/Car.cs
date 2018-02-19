using System;

namespace PragueParking2 {
    public class Car : Vehicle
    {
        public Car(string regNr, DateTime arrivalTime, int size) : base(regNr, arrivalTime, size)
        {
            this.size = 4;
        }
    }

}