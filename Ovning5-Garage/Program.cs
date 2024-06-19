using Ovning5_Garage.Interfaces;
using Ovning5_Garage.Models;
using Ovning5_Garage.Services;
using Ovning5_Garage.UserInterface;



namespace Ovning5_Garage
{
    internal class Program
    {
        static void Main()
        {
            // Steg 1: Inställning för garaget med en angiven kapacitet
            int garageCapacity = 500; // Exempel på kapacitet
            var garage = new Garage<Vehicle>(garageCapacity); // Skapa ett nytt garagesystem med kapaciteten 500

            // Steg 2: Starta Garagehandler
            IHandler handler = new GarageHandler(garage);

            // Steg 3: Starta IUI
            IUI ui = new UI(handler); // Skapa ett nytt UI som använder den nya handlern

            // Steg 4: Starta den nya ui
            ui.Start();
        }

    }
}
