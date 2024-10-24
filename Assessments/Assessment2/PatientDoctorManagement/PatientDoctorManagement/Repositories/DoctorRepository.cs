using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using PatientDoctorManagement.Models;

namespace PatientDoctorManagement.Repositories
{
    internal class DoctorRepository
    {
        private SqlConnection _connection;
        public DoctorRepository()
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Rahul vv\Documents\QuestDB.mdf';Integrated Security=True;");
        }

        public void Create(Doctor doctor)
        {
            EnsureConnectionIsOpen();
            var sql = "INSERT INTO Doctor (Name, Specialization) VALUES (@Name, @Specialization)";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@Name", doctor.Name);
            command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
            command.ExecuteNonQuery();
        }

        public List<Doctor> GetAll()
        {
            EnsureConnectionIsOpen();
            var sql = "SELECT Id, Name, Specialization FROM Doctor";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();

            var doctors = new List<Doctor>();
            while (reader.Read())
            {
                doctors.Add(new Doctor
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Specialization = (string)reader["Specialization"]
                });
            }
            return doctors;
        }

        private void EnsureConnectionIsOpen()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }
    }
}
