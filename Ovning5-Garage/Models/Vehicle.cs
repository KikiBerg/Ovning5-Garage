using Ovning5_Garage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5_Garage.Models
{
    // Definiera klassen Vehicle som samtliga subklasser ärver ifrån.
    public class Vehicle : IVehicle
    {
        // Deklarera klassens olika egenskaper
        public string RegistrationNumber { get; set; }
        public string Colour { get; set; }
        public int NumOfWheels { get; set; }

        // Konstruktor för att skapa ett nytt fordonsobjekt
        public Vehicle(string registrationNumber, string colour, int numOfWheels) 
        {
            // Här tilldelar jag de angivna värdena till fordonets egenskaper
            RegistrationNumber = registrationNumber;
            Colour = colour;
            NumOfWheels = numOfWheels;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {RegistrationNumber}, {Colour}, {NumOfWheels} hjul";
        }


    }
}
