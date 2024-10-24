using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PatientDoctorManagement.Models;

namespace PatientDoctorManagement.Repositories
{
    internal class PatientRepository
    {
        private SqlConnection _connection;

        public PatientRepository()
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Rahul vv\Documents\QuestDB.mdf';Integrated Security=True;");
        }

        public void Create(Patient patient)
        {
            EnsureConnectionIsOpen();
            var sql = "INSERT INTO Patient (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@Name", patient.Name);
            command.Parameters.AddWithValue("@Age", patient.Age);
            command.Parameters.AddWithValue("@Gender", patient.Gender);
            command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
            command.ExecuteNonQuery();
        }

        public List<Patient> GetAll()
        {
            EnsureConnectionIsOpen();
            var sql = "SELECT Id, Name, Age, Gender, MedicalCondition FROM Patient";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();

            var patients = new List<Patient>();
            while (reader.Read())
            {
                patients.Add(new Patient
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Age = (int)reader["Age"],
                    Gender = (string)reader["Gender"],
                    MedicalCondition = (string)reader["MedicalCondition"]
                });
            }
            return patients;
        }

        public void Update(Patient patient)
        {
            EnsureConnectionIsOpen();
            var sql = "UPDATE Patient SET Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition WHERE Id = @Id";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@Name", patient.Name);
            command.Parameters.AddWithValue("@Age", patient.Age);
            command.Parameters.AddWithValue("@Gender", patient.Gender);
            command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
            command.Parameters.AddWithValue("@Id", patient.Id);
            command.ExecuteNonQuery();
        }

        public Patient GetById(int id)
        {
            EnsureConnectionIsOpen();
            var sql = "SELECT Id, Name, Age, Gender, MedicalCondition FROM Patient WHERE Id = @Id";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@Id", id);
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Patient
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Age = (int)reader["Age"],
                    Gender = (string)reader["Gender"],
                    MedicalCondition = (string)reader["MedicalCondition"]
                };
            }

            return null;
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
