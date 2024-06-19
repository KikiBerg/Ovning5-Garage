using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning5_Garage.Models;

namespace Ovning5_Garage.Interfaces
{
    /* Detta gränssnitt definierar de metoder som alla UI-implementeringar måste ha. 
     * Detta gör det lättare att hantera UI-klassen.
     */
    public interface IUI
    {
        void Start();
        void ListAllVehicles();
        void ListVehicleTypesAndCounts();
        void AddVehicle();
        void RemoveVehicle();
        void FindVehicle();
    }
}
