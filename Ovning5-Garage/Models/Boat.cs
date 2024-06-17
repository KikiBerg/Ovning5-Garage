using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5_Garage.Models
{
    public class Boat : Vehicle // Definierar en klass som ärver från Vehicle
    {
        //Deklarera unika egenskaper för Boat
        public double Length { get; set; }

        // Konstruktor för Boat som tar registreringsnummer, färg, antal hjul och längd som parametrar
        public Boat(string registrationNumber, string colour, int numOfWheels, double length) : base (registrationNumber, colour, numOfWheels) // Anropa basklassens konstruktor för att initialisera gemensamma attribut
        {
            // Initialisera den unika attributen för Boat
            Length = length;
        }

    }
}
