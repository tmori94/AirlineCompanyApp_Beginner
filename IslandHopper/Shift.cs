using System;
using IslandHopper;
using IHEmployee;

namespace IslandHopper
{
    public class Shift
    {
        private string EmployeeID;
        private string Date;
        private int StartTime;
        private int EndTime;
        private int HoursWorked;


        // constructor
        public Shift(string employeeID1, string date1, int startTime1, int endTime1, int hoursWorked1)
        {
            this.EmployeeID = employeeID1;
            this.Date = date1;
            this.StartTime = startTime1;
            this.EndTime = endTime1;
            this.HoursWorked = hoursWorked1;

            try
            {
                Employee empl = Globals.listOfEmployees.Find(x => x.employeeID == employeeID);
                //empl.addContent(this);
                empl.shiftRotas.Add(this);
                //Console.WriteLine(empl.employeeID);

                //Console.WriteLine(empl.name);
                //Globals.listOfEmployees.Find(x => x.employeeID == employeeID).addContent(this);

            }
            catch (Exception ex)
            {
                Console.WriteLine("there is an error:" + ex);
            }
        }

        public string employeeID
        {
            get { return EmployeeID; }
            set
            {
                //foreach (var employee in Globals.listOfEmployees)
                //{
                //    if (employee.employeeID == employeeID)
                //    {
                //        EmployeeID = value;
                //        break;
                //    }
                //}
            }
        }

        public string date
        { get => Date; set => Date = value; }

        public int startTime
        { get => StartTime; set => StartTime = value; }

        public int endTime
        { get => EndTime; set => EndTime = value; }

        public int hoursWorked
        { get => HoursWorked; set => HoursWorked = value; }

        //public void printString()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("sono lo shift... uuuuhhh");
        //    Console.WriteLine($"Employee ID:  {this.employeeID}");
        //    Console.WriteLine($"Date: {this.date}");
        //    Console.WriteLine($"Start Time: {this.startTime}");
        //    Console.WriteLine($"End Time: {this.endTime}");
        //    Console.WriteLine($"Hours Worked: {this.hoursWorked}");
        //    Console.WriteLine();
        //}
    }
}
