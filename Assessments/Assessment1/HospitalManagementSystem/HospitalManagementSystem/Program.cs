using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    internal class Program
    {
        static Dictionary<string, List<string>> departments = new Dictionary<string, List<string>>();
        static Dictionary<string, Dictionary<string, bool>> patients = new Dictionary<string, Dictionary<string, bool>>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Hospital Management System ---");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Add Doctor to the Department");
                Console.WriteLine("3. Admit Patient to the Doctor");
                Console.WriteLine("4. Show Doctors in a Department");
                Console.WriteLine("5. Show Patients of a Doctor");
                Console.WriteLine("6. Discharge the Patient");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddDepartment();
                        break;
                    case "2":
                        AddDoctor();
                        break;
                    case "3":
                        AdmitPatient();
                        break;
                    case "4":
                        ListDoctors();
                        break;
                    case "5":
                        ListPatientsOfDoctor();
                        break;
                    case "6":
                        DischargePatient();
                        break;
                    case "7":
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        //ADD NEW DEPARTMENT
        static void AddDepartment()
        {
            Console.Write("Enter department name: ");
            var dept = Console.ReadLine();
            if (!departments.ContainsKey(dept))
            {
                departments[dept] = new List<string>();
                Console.WriteLine($"Department '{dept}' added.");
            }
            else
            {
                Console.WriteLine("Department already exists.");
            }
        }

        //ADD DOCTOR
        static void AddDoctor()
        {
            Console.Write("Enter Department: ");
            var dept = Console.ReadLine();

            if (departments.ContainsKey(dept))
            {
                Console.Write("Enter Doctor's name: ");
                var dr = Console.ReadLine();

                if (!departments[dept].Contains(dr))
                {
                    departments[dept].Add(dr);
                    patients[dr] = new Dictionary<string, bool>();
                    Console.WriteLine($"Dr.{dr} added to {dept}.");
                }
                else
                {
                    Console.WriteLine("Doctor already exists.");
                }
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }

        //ADMIT PATIENT
        static void AdmitPatient()
        {
            Console.Write("Enter Doctor's name: ");
            var dr = Console.ReadLine();
            if (patients.ContainsKey(dr))
            {
                Console.Write("Enter patient name: ");
                var patient = Console.ReadLine();
                patients[dr][patient] = true; 
                Console.WriteLine($"{patient} admitted to Dr.{dr}.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        //LIST DOCTORS
        static void ListDoctors()
        {
            Console.Write("Enter Department name: ");
            var dept = Console.ReadLine();
            if (departments.ContainsKey(dept))
            {
                Console.WriteLine($"Doctors in {dept} are:");
                foreach (var dr in departments[dept])
                {
                    Console.WriteLine(dr);
                }
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }

        //LIST PATIENTS
        static void ListPatientsOfDoctor()
        {
            Console.Write("Enter doctor name: ");
            var dr = Console.ReadLine();
            if (patients.ContainsKey(dr))
            {
                Console.WriteLine($"Patients of Doctor '{dr}':");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        //DISCHARGE PATENT
        static void DischargePatient()
        {
            Console.Write("Enter Doctor name: ");
            var dr = Console.ReadLine();
            if (patients.ContainsKey(dr))
            {
                Console.Write("Enter patient: ");
                var pat = Console.ReadLine();

                if (patients.ContainsKey(pat))
                {
                    patients[dr][pat] = false; 
                    Console.WriteLine($"{pat} discharged.");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }
    }
}