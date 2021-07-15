using System;
using System.Collections.Generic;
using IslandHopper;

namespace IHEmployee
{
    public class Employee
    {
        private string Name;
        private string EmployeeID;
        private string DateOfBirth;
        private string Role;
        private string Email;
        private List<Shift> ShiftRotas;
        private int VacationDays;


        // constructor
        public Employee(string name, string dateOfBirth, string role, string email)
        {
            this.Name = name;
            this.EmployeeID = generateEmployeeID(role);
            this.DateOfBirth = dateOfBirth;
            this.Role = role;
            this.Email = email;
            this.ShiftRotas = new List<Shift>();
            this.VacationDays = 25;
            Globals.listOfEmployees.Add(this);
        }

        private string generateEmployeeID(string role)
        {
            string startLetter;
            string newEmployeeID;

            switch (role.ToLower())
            {
                case "cabin crew":
                    startLetter = "A";
                    break;
                case "technician":
                    startLetter = "B";
                    break;
                case "pilot":
                    startLetter = "C";
                    break;
                case "back office":
                    startLetter = "D";
                    break;
                case "check in staff":
                    startLetter = "E";
                    break;
                default:
                    startLetter = "INVALID";
                    break;
            }

            if (Globals.listOfEmployees.Count != 0) // list is not empty
            {
                Employee lastEmployee = Globals.listOfEmployees[^1];
                string lastEmployeeID = lastEmployee.employeeID;
                string lastId = lastEmployeeID.Substring(lastEmployeeID.Length - 4);
                try
                {
                    int lastIdInt = Int32.Parse(lastId);
                    int newIdInt = lastIdInt + 1;
                    if (startLetter != "INVALID")
                    {
                        newEmployeeID = startLetter + newIdInt;
                        return newEmployeeID;
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong.");
                        return "";
                    }
                }
                catch (FormatException e)
                {
                    //Console.WriteLine(e.Message);
                    return null;
                }
            }
            else
            {
                newEmployeeID = startLetter + "1001";
               return newEmployeeID;
            }
        }

        public string employeeID
        {
            get { return EmployeeID; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string dateOfBirth
        { get; set; }

        public string role
        {
            get { return Role; }
            set
            {
                switch (value.ToLower())
                {
                    case "cabin crew":
                        Role = value;
                        break;
                    case "technician":
                        Role = value;
                        break;
                    case "pilot":
                        Role = value;
                        break;
                    case "back office":
                        Role = value;
                        break;
                    case "check in staff":
                        Role = value;
                        break;
                    default:
                        Role = "NO ROLE IS DEFINED.";
                        break;
                }
            }
        }

        public string email
        { get; set; }

        public int vacationDays
        { get; set; }

        public List<Shift> shiftRotas => ShiftRotas;

        public static void deleteEmployee(string ID)
        {
            int idxEmployee;
            foreach (var employee in Globals.listOfEmployees)
            {
                if (employee.employeeID == ID)
                {
                    idxEmployee = Globals.listOfEmployees.IndexOf(employee);
                    Globals.listOfEmployees.RemoveAt(idxEmployee);
                    break;
                }
            }
        }

        public void addContent(Shift work)
        {
            ShiftRotas.Add(work);
        }
    }

    public class Pilot : Employee
    {
        private string LicenseID;

        public Pilot(String licenseID, string name, string dateOfBirth, string email, string role = "pilot"): base(name,dateOfBirth,role,email)
        {
            LicenseID = licenseID;
        }

        public string licenseID
        {
            get { return licenseID; }
            set { LicenseID = value; }
        }
    }
}
