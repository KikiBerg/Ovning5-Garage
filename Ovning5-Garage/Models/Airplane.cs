using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5_Garage.Models
{
    public class Airplane : Vehicle
    {
        // Egenskap unik för flygplan som anger antalet motorer
        public int NumOfEngines { get; set; }

        // Konstruktor för Airplane-klassen som tar registreringssnummer, färg, antal hjul och antal motorer som parametrar
        public Airplane(string registrationNumber, string colour, int numOfWheels, int numOfEngines):base(registrationNumber, colour, numOfWheels) 
        {
            NumOfEngines = numOfEngines; // Tilldelar det angivna värdet till egenskapen NumOfEngines
        }
    }
}
