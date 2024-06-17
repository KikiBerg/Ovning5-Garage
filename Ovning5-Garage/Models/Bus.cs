using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5_Garage.Models
{
    public class Bus : Vehicle // Definierar en klass som ärver från Vehicle
    {
        //Deklarera unika egenskaper för Bus
        public int NumOfSeats { get; set; }

        // Konstruktor för Bus som tar registreringsnummer, färg, antal hjul och antal sittplatser som parametrar
        public Bus(string registrationNumber, string colour, int numOfWheels, int numOfSeats) : base(registrationNumber, colour, numOfWheels) // Anropa basklassens konstruktor för att initialisera gemensamma attribut
        {
            // Initialisera den unika attributen för Bus
            NumOfSeats = numOfSeats;
        }
    }
}
