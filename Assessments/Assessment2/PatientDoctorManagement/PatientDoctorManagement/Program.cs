using System;
using System.Collections.Generic;

namespace PatientDoctorManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patientManager = new PatientManager();
            var doctorManager = new DoctorManager();

            while (true) 
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. List All Patients");
                Console.WriteLine("4. List All Doctors");
                Console.WriteLine("5. Update Patient Details");
                Console.WriteLine("6. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        patientManager.AddPatient();
                        break;

                    case "2":
                        doctorManager.AddDoctor();
                        break;

                    case "3":
                        patientManager.GetAllPatients();
                        break;

                    case "4":
                        doctorManager.GetAllDoctors();
                        break;

                    case "5":
                        patientManager.UpdatePatient();
                        break;

                    case "6":
                        Console.WriteLine("Exiting...");
                        return; 

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine(); 
            }
        }
    }
}


class employee
{
    public string Name { get; set; }
    

}

class Manager : employee
{
    public string Designation { get; set; } 
}

class program
{
    static void main(string[] args)
    {
        List<employee> employees = new List<employee>();
    }
}