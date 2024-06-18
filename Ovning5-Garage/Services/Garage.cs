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

        public Garage(int capacity) // Konstruktor för att initialisera garaget med en viss kapacitet
        {
            this.capacity = capacity;
            vehicles = new T[capacity]; // Skapar ett nytt array av typen T med den angivna kapaciteten
            count = 0; // Initialiserar antalet fordon till 0
        }

        // Metod för att parkera ett fordon i garaget
        public bool AddVehicle(T vehicle)
        {
            if (count >= capacity) // Kontrollerar om garaget är fullt
            {
                Console.WriteLine("Garaget är full. Kan inte parkera fler fordon."); // Meddelande om att garaget är fullt
                return false; // Returnerar false för att indikera misslyckad parkering
            }

            vehicles[count++] = vehicle; // Parkerar fordonet och ökar räknaren
            count++;
            return true; // Returnerar true vid lyckad parkering
        }



    }




}

