using System;
using System.Collections.Generic;

namespace IslandHopper
{
    public class Aircraft
    {
        private string AircraftID;
        private int Seat;
        private string PilotID;
        private List<Maintenance> MaintenanceList;
        
        public Aircraft(string aircraftID, int seat, string pilotID)
        {
            this.AircraftID = aircraftID;
            this.Seat = seat;
            this.PilotID = pilotID;
            this.MaintenanceList = new List<Maintenance>();
            Globals.listOfAircrafts.Add(this);
        }

        public string aircraftID
        {
            get => AircraftID; set => AircraftID = value;
        }

        public int seat
        {
            get => Seat; set => Seat = value;
        }

        public string pilotID
        {
            get => PilotID; set => PilotID = value;
        }

        // getter

        public List<Maintenance> maintenanceList
        {
            get => MaintenanceList;
        }
        

    }
}
