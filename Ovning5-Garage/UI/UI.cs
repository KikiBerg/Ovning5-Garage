using Ovning5_Garage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning5_Garage.Models;


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


        public void AddVehicle()
        {
            throw new NotImplementedException();
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
