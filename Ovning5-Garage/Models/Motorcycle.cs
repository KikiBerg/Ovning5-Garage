using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5_Garage.Models
{
    public class Motorcycle : Vehicle
    {
        // Unik egenskap för Motorcykel, representerar cylindervolymen
        public double CylinderVolume { get; set; }

        // Konstruktor för Motorcykel som tar registreringsnummer, färg, antal hjul och cylindervolym som parametrar
        public Motorcycle(string registrationNumber, string colour, int numOfWheels, double cylinderVolume) : base(registrationNumber, colour, numOfWheels)
        {
            CylinderVolume = cylinderVolume; // Tilldelar cylindervolymet till egenskapen CylinderVolume
        }   
      

        
       
    }
}
