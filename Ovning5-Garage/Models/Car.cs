using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5_Garage.Models
{
    public class Car : Vehicle // Definierar en klass som ärver från Vehicle
    {
        //Deklarera unika egenskaper för Car
        public string FuelType { get; set; }
        public bool HasAirSuspension { get; set; }

        // Konstruktor för Car
        public Car(string registrationNumber, string colour, int numOfWheels, string fuelType, bool hasAirSuspension) : base (registrationNumber, colour, numOfWheels)// Anropa basklassens konstruktor för att initialisera gemensamma attribut
        {
            // Initialisera de unika attributen för Car
            FuelType = fuelType;
            HasAirSuspension = hasAirSuspension;
        }


      
    }
}
