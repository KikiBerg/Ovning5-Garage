using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning5_Garage.Models;

namespace Ovning5_Garage.Services
{

     
    public class Garage<T> : IEnumerable<T> where T : Vehicle //Definiera en generisk klass som hanterar objekt av typ Vehicle
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

        // Metod för att ta bort ett fordon från garaget baserat på registreringsnummer
        public bool RemoveVehicle(string registrationNumber)
        {
            for (int i = 0; i < count; i++) // Loopar alla fordon i garaget
            {
                if (vehicles[i].RegistrationNumber.Equals(registrationNumber, StringComparison.OrdinalIgnoreCase)) // Kontrollerar om något fordon matchar det angivna registreringsnumret
                {
                    // Flyttar fordon för att fylla upp ledigt utrymme
                    for (int j = i; j < count -1; j++)
                    {
                        vehicles[j] = vehicles[j+1];
                    }
                    vehicles[--count] = null; // Sätter det sista elementet i arrayen till null och minskar räknaren
                    return true; // Returnerar true för att indikera att borttagningen lyckades
                }
            }
            Console.WriteLine("Fordonet hittades inte");
            return false; // Returnerar false vid misslyckat försök
        }

        // Metod för att hitta ett fordon i garaget baserat på registreringsnummer
        public T FindVehicle(string registrationNumber)
        {
            foreach (T vehicle in vehicles) // Loopar alla fordon i garaget
            {
                if (vehicle!= null && vehicle.RegistrationNumber.Equals(registrationNumber, StringComparison.OrdinalIgnoreCase)) // Kontrollerar om något fordon matchar det angivna registreringsnumret
                {
                    return vehicle; // Returnerar det hittade fordonet
                }
            }
            return null; // Returnerar null om inget fordon hittades
        }

        // Implementerar IEnumerable interface för att kunna iterera över fordon i garaget
        public IEnumerator<T> GetEnumerator()
        {
                      
           for (int i = 0; i < count; i++) // Loopar alla fordon i garaget
            {
                if (vehicles[i] != null)
                yield return vehicles[i]; // Återlämnar varje fordon i turordning
            }
        }

        IEnumerator IEnumerable.GetEnumerator() // Alternativ implementering av IEnumerable interface för kompatibilitet med ic-generic metoder
        {
            return GetEnumerator();
        }

        // Metod för att få kapaciteten på garaget
        public int GetCapacity()
        { 
            return capacity;
        }

        // Metod för att få antalet fordon i garaget
        public int GetCount()
        {
            return count;
        }

    }

}

