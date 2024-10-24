using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDoctorManagement.Models;
using PatientDoctorManagement.Repositories;

namespace PatientDoctorManagement
{
    internal class DoctorManager
    {
        private DoctorRepository _doctorRepository;

        public DoctorManager()
        {
            _doctorRepository = new DoctorRepository();
        }

        public void AddDoctor()
        {
            var doctor = new Doctor();

            Console.Write("Enter doctor name: ");
            doctor.Name = Console.ReadLine();

            Console.Write("Enter doctor specialization: ");
            doctor.Specialization = Console.ReadLine();

            _doctorRepository.Create(doctor);
        }

        public void GetAllDoctors()
        {
            var doctors = _doctorRepository.GetAll();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"{doctor.Id} - {doctor.Name} - {doctor.Specialization}");
            }
        }
    }
}
