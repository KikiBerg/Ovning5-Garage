using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning5_Garage.Models;

namespace Ovning5_Garage.Interfaces
{

    /*
     * Det här gränssnitt definierar kontraktet för att hantera operationer relaterade till garaget.
     * Definierar metoder som en klass (t.ex., GarageHandler) måste implementera för att hantera garagesoperationer
     * Metoder inkluderar att skapa ett garage, lägga till/ta bort fordon, lista fordon osv.
     */

    public interface IHandler
    {
        void CreateGarage(int capacity); // Metod för att skapa en garage med angiven kapacitet
        void AddVehicle(Vehicle vehicle); // Metod för att lägga till ett fordon till garagen
        void RemoveVehicle(string registrationNumber); // Metod för att ta bort ett fordon från garage baserat på registreringsnumret
        void ListAllVehicles(); // Metod för att lista alla fordon i garaschen
        void ListVehicleTypesAndCounts(); // Metod för att lista fordonstyper och deras antal
        Vehicle? FindVehicle(string registrationNumber); // Metod för att hitta ett fordon baserat på registreringsnumret
    }
}
