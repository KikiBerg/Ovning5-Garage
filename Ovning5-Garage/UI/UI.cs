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

        // Metod för att söka efter ett fordon i garagen baserat på dess registreringsnummer
        public void FindVehicle()
        {
            Console.WriteLine("Ange registreringsnumret för fordonet du vill hitta:");
            
            string registrationNumber = Console.ReadLine();
            
            var vehicle = _handler.FindVehicle(registrationNumber);
            if (vehicle != null)
            {
                Console.WriteLine($"{vehicle.GetType().Name}: {vehicle.RegistrationNumber}, {vehicle.Colour}, {vehicle.NumOfWheels} hjul");
            }
            else
            {
                Console.WriteLine("Fordonet hittades inte.");
            }
        }


        // Metod för att lista alla fordon i garagen
        public void ListAllVehicles()
        {
            _handler.ListAllVehicles();
        }

        // Metod för att visa hur många av varje typ av fordon som finns i garagen
        public void ListVehicleTypesAndCounts()
        {
            _handler.ListVehicleTypesAndCounts();
        }

        // Metod för att ta bort ett fordon från garagen baserat på dess registreringsnummer
        public void RemoveVehicle()
        {
            Console.WriteLine("Ange registreringsnumret för fordonet du vill ta bort:");
            
            string registrationNumber = Console.ReadLine();
            _handler.RemoveVehicle(registrationNumber);
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
