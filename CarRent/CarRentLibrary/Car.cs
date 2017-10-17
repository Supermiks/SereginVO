using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentLibrary
{
    public class Car
    {
        public Car(string modelName, string color, OccupationStatus occupationStatus)
        {
            this.modelName = modelName;
            this.color = color;
            this.occupationStatus = occupationStatus;
        }

        string modelName;
        string color;
        OccupationStatus occupationStatus; 

        public override string ToString()
        {
            return modelName + " " + color + " " + occupationStatus;
        }
    }
}
