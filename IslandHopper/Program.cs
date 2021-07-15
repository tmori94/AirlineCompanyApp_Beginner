using System;
using System.Collections.Generic;
using System.Diagnostics;
using IHEmployee;
using IslandHopper;

namespace IslandHopper
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("start");
            Employee tommaso = new Employee("Tommaso Mori", "26-08-1994", "technician", "tommaso@me.com");

            Console.WriteLine("middle");
            Employee omar = new Employee("Omar Manfroi", "aa-bb-cc", "back office", "omar@me.com");
            Console.WriteLine(Globals.listOfEmployees.Count);
            

        }
    }
}


        // cabincrew = A, technician = B, pilot = C, backoffice = D, checkinstaff = E

    // Class to define global variables, accessible in all locations
    public class Globals
    {

        public static List<Employee> listOfEmployees = new List<Employee>();
    //    if(!listOfEmployees) {
            
    //    }

        public static List<Aircraft> listOfAircrafts = new List<Aircraft>();
    }


//List<Employee> listOfEmployees = new List<Employee>();
//Console.WriteLine("start");
//Employee tommaso = new Employee("Tommaso Mori", "26-08-1994", "technician", "tommaso@me.com");
//Globals.listOfEmployees.Add(tommaso);

//Console.WriteLine(listOfEmployees.Count);
//Console.WriteLine("middle");
//Employee omar = new Employee("Omar Manfroi", "aa-bb-cc", "back office", "omar@me.com");
//Globals.listOfEmployees.Add(omar);
//Console.WriteLine(Globals.listOfEmployees.Count);
//Pilot tom = new Pilot("AA200DD", "Tommaso Mori", "26-08-94", "tommaso@me.com");
//Globals.listOfEmployees.Add(tom);
//Console.WriteLine("Employees are: " + Globals.listOfEmployees.Count);

//Shift newShiftTommaso = new Shift("B1001", "16-06-2021", 0800, 1800, 10);
//newShiftTommaso.printString();
//tommaso.shiftRotas.Add(newShiftTommaso);
//Console.WriteLine(tommaso.shiftRotas.Count);

//Shift newShiftTommaso2 = new Shift("B1001", "10-10-2021", 1000, 1400, 2);
//newShiftTommaso2.printString();
//tommaso.shiftRotas.Add(newShiftTommaso2);

//Console.WriteLine(tommaso.employeeID);
//Console.WriteLine(tommaso.name);
//Console.WriteLine(tommaso.shiftRotas.Count);

//Console.WriteLine(newShiftTommaso.employeeID);
//Console.WriteLine(newShiftTommaso.date);

//Aircraft plane1 = new Aircraft("AA200", 100, "AA200DD");
//Aircraft plane2 = new Aircraft("AA201", 130, "0000000");
//Aircraft plane3 = new Aircraft("AA202", 130, "0000000");

//Console.WriteLine(Globals.listOfAircrafts.Count);