using System;
namespace IslandHopper
{
    public class Maintenance
    {
        private string MaintenanceID;
        private string EmployeeID;
        private string Details;

        // constructor
        public Maintenance(string maintenanceID, string employeeID, string details)
        {
            this.MaintenanceID = maintenanceID;
            this.EmployeeID = employeeID;
            this.Details = details;

            // code to add this maintenance into an aircraft object
        }

        public string maintenanceID
        {
            get => maintenanceID; set => maintenanceID = value;
        }

        public string employeeID
        {
            get => employeeID; set => employeeID = value;
        }

        public string details
        {
            get => details; set => details = value;
        }
    }
}
