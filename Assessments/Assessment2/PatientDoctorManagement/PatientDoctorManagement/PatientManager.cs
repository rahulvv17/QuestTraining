using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDoctorManagement.Models;
using PatientDoctorManagement.Repositories;

namespace PatientDoctorManagement
{
    internal class PatientManager
    {
        private PatientRepository _patientRepository;

        public PatientManager()
        {
            _patientRepository = new PatientRepository();
        }

        public void AddPatient()
        {
            var patient = new Patient();

            Console.Write("Enter patient name: ");
            patient.Name = Console.ReadLine();

            Console.Write("Enter patient age: ");
            patient.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter patient gender: ");
            patient.Gender = Console.ReadLine();

            Console.Write("Enter medical condition: ");
            patient.MedicalCondition = Console.ReadLine();

            _patientRepository.Create(patient);
        }

        public void GetAllPatients()
        {
            var patients = _patientRepository.GetAll();
            foreach (var patient in patients)
            {
                Console.WriteLine($"{patient.Id} - {patient.Name} - {patient.Age} - {patient.Gender} - {patient.MedicalCondition}");
            }
        }

        public void UpdatePatient()
        {
            Console.Write("Enter the ID of the patient to update: ");
            var patientId = int.Parse(Console.ReadLine());

            var patient = _patientRepository.GetById(patientId);
            if (patient == null)
            {
                Console.WriteLine("Patient not found.");
                return;
            }

            Console.WriteLine("What would you like to update?");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Age");
            Console.WriteLine("3. Gender");
            Console.WriteLine("4. Medical Condition");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter new name: ");
                    patient.Name = Console.ReadLine();
                    break;

                case "2":
                    Console.Write("Enter new age: ");
                    patient.Age = int.Parse(Console.ReadLine());
                    break;

                case "3":
                    Console.Write("Enter new gender: ");
                    patient.Gender = Console.ReadLine();
                    break;

                case "4":
                    Console.Write("Enter new medical condition: ");
                    patient.MedicalCondition = Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            _patientRepository.Update(patient);
            Console.WriteLine("Patient details updated successfully.");
        }
    }
}
