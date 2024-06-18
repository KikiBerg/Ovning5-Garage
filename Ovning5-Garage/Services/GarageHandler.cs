using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning5_Garage.Models;
using System.Collections;

namespace Ovning5_Garage.Services
{

    /*
     * Den här klassen fungerar som en mellanhand mellan användargränssnittet och Garage-klassen.
     * Den erbjuder metoder för att lägga till, ta bort, hitta och lista fordon i garaget. 
     */

    public class GarageHandler
    {
        private Garage<Vehicle> garage; // Anslag till en generisk garage för fordonstyper

        // Metod för att skapa en ny garage med angiven kapacitet
        public void CreateGarage(int capacity)
        {
            garage = new Garage<Vehicle>(capacity); // Skapar en ny instans av Garage med kapaciteten som parameter
            Console.WriteLine($"Garage skapad med kapacitet: {capacity}");
        }

        // Metod för att lägga till ett fordon i garagen
        public void AddVehicle(Vehicle vehicle)
        {
            if (garage.AddVehicle(vehicle)) // Försöker lägga till fordonet i garagen
            {
                Console.WriteLine($"Fordon med registreringsnummer {vehicle.RegistrationNumber} har lagts till.");
            }
            else
            {
                Console.WriteLine("Garaget är full, det är inte möjligt att lägga till fordon.");
            }
        }


        // Metod för att ta bort ett fordon från garagen baserat på dess registreringsnummer
        public void RemoveVehicle(string registrationNumber)
        {
            if (garage.RemoveVehicle(registrationNumber)) // Försöker ta bort fordonet från garagen
            {
                Console.WriteLine($"Fordon med registreringsnummer {registrationNumber} är borttaget.");
            }
            else
            {
                Console.WriteLine("Fordon kunde inte hittas eller tas bort.");
            }
        }



    }
}
