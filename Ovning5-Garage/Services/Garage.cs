using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning5_Garage.Models;

namespace Ovning5_Garage.Services
{
    public class Garage<T> : where T : Vehicle //Definiera en generisk klass som hanterar objekt av typ Vehicle
    {
        private T[] vehicles;   // Array för att lagra fordon
        private int capacity;   // Kapaciteten på garaget
        private int count;      // Antalet fordon i garaget
    }

    


}

