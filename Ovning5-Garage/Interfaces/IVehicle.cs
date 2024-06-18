using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ovning5_Garage.Interfaces
{

    /* Det här gränssnitt definierar kontraktet för fordon.
     * Definierar egenskaper som en klass (t.ex., Vehicle och dess subklasser) måste implementera för att representera ett fordon:
     */


    public interface IVehicle
    {
        string RegistrationNumber { get; set; } // Denna egenskap representerar det unika registreringsnumret för fordonet.
        string Colour { get; set; } // Denna egenskap representerar färgen på fordonet.
        int NumOfWheels { get; set; } // Denna egenskap representerar antalet hjul på fordonet.
    }
}
