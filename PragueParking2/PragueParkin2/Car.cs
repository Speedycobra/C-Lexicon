using System;

namespace PragueParking2 {
    public class Car : Vehicle
    {
        public Car(string regNr, DateTime arrivalTime) : base(regNr, arrivalTime, 4)
        {
            
        }
    }

}