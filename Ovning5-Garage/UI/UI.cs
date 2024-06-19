using Ovning5_Garage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning5_Garage.Models;
using System.Drawing;


namespace Ovning5_Garage.UI
{
    public class UI : IUI
    {
        // Deklarera en privat variabel för IHandler, initialiserad till null
        private IHandler? _handler;

        // Konstruktor för att injicera IHandler-objektet
        public UI(IHandler handler) 
        {
            _handler = handler;
        }


        // Metod för att lägga till ett nytt fordon
        public void AddVehicle()
        {
            Console.WriteLine("Ange fordontypen (Flygplan, Motorcykel, Bil, Buss, Båt):");
            string type = Console.ReadLine();
            
            Console.WriteLine("Ange registreringsnumret:");
            string registrationNumber = Console.ReadLine();
            
            Console.WriteLine("Ange färgen:");
            string colour = Console.ReadLine();
            
            Console.WriteLine("Ange antalet hjul:");
            int numOfWheels = int.Parse(Console.ReadLine());

            // Skapar ett nytt fordonobjekt baserat på användarinput
            Vehicle vehicle = type.ToLower() switch
            {
                "flygplan" => new Airplane(registrationNumber, colour, numOfWheels, 2), // Standardantal motorer
                "motorcykel" => new Motorcycle(registrationNumber, colour, numOfWheels, 1000), // Standard cylindervolym
                "bil" => new Car(registrationNumber, colour, numOfWheels, "Bensin"), // Standard bränsletyp
                "buss" => new Bus(registrationNumber, colour, numOfWheels, 50), // Standardantal platser
                "båt" => new Boat(registrationNumber, colour, numOfWheels, 30), // Standard längd
                _ => null
            };

            // Jag kontrollerar om objektet är giltigt och lägger till det i handler
            if (vehicle != null)
            {
                _handler.AddVehicle(vehicle);
            }
            else
            {
                Console.WriteLine("Ogiltig fordonstyp");
            }



        }

        public void FindVehicle()
        {
            throw new NotImplementedException();
        }

        public void ListAllVehicles()
        {
            throw new NotImplementedException();
        }

        public void ListVehicleTypesAndCounts()
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
