using HastaneYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimSistemi.Managers
{
    public interface IDoctorManager
    {
        void Create(NewDoctorModel model);
        NewDoctorModel ReadOne(int Id);
        List<NewDoctorModel> ReadAll();
        void Update(NewDoctorModel model);
        void Delete(int Id);
    }
    public class DoctorManager : IDoctorManager
    {
        private string connectionString;

        public DoctorManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
        }

        public void Create(NewDoctorModel model)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Doctor (RegisterDate, Active, Deleted, Firstname, Lastname, Department, Speciality, Email, BloodType, Gender, CallNumber, NationalId, DateOfBirth) VALUES (@RegisterDate, @Active, @Deleted, @Firstname, @Lastname, @Department, @Specialization, @Email, @BloodType, @Gender, @PhoneNumber, @NationalId, @DateOfBirth)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Firstname", model.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", model.Lastname);
                cmd.Parameters.AddWithValue("@Department", model.Department);
                cmd.Parameters.AddWithValue("@Specialization", model.Specialization);
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@BloodType", model.BloodType);
                cmd.Parameters.AddWithValue("@Gender", model.Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                cmd.Parameters.AddWithValue("@NationalId", model.NationalId);
                cmd.Parameters.AddWithValue("@DateOfBirth", model.DateOfBirth);
                cmd.Parameters.AddWithValue("@RegisterDate", model.RegisterDate);
                cmd.Parameters.AddWithValue("@Active", model.Active);
                cmd.Parameters.AddWithValue("@Deleted", model.Deleted);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Doctor WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<NewDoctorModel> ReadAll()
        {
            List<NewDoctorModel> result = new List<NewDoctorModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Doctor";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new NewDoctorModel
                        {
                            Id = reader.GetInt32(0),
                            Firstname = reader.GetString(1),
                            Lastname = reader.GetString(2),
                            RegisterDate = reader.GetDateTime(3),
                            Active = reader.GetBoolean(4),
                            Deleted = reader.GetBoolean(5),
                            Department = reader.GetString(6),
                            Specialization = reader.GetString(7),
                            PhoneNumber = reader.GetInt64(8),
                            NationalId = reader.GetInt64(9),
                            BloodType = reader.GetString(10),
                            Gender = reader.GetString(11),
                            Email = reader.GetString(12),
                            DateOfBirth = reader.GetDateTime(13)
                        });
                    }
                }
            }
            return result;
        }

        public NewDoctorModel ReadOne(int Id)
        {
            NewDoctorModel result = new NewDoctorModel();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Doctor WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = new NewDoctorModel()
                        {
                            Id = reader.GetInt32(0),
                            Firstname = reader.GetString(1),
                            Lastname = reader.GetString(2),
                            RegisterDate = reader.GetDateTime(3),
                            Active = reader.GetBoolean(4),
                            Deleted = reader.GetBoolean(5),
                            Department = reader.GetString(6),
                            Specialization = reader.GetString(7),
                            PhoneNumber = reader.GetInt64(8),
                            NationalId = reader.GetInt64(9),
                            BloodType = reader.GetString(10),
                            Gender = reader.GetString(11),
                            Email = reader.GetString(12),
                            DateOfBirth = reader.GetDateTime(13)
                        };
                    }
                }
            }

            return result;
        }

        public void Update(NewDoctorModel model)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Doctor SET RegisterDate = @RegisterDate, Active = @Active, Deleted = @Deleted, Firstname = @Firstname, Lastname = @Lastname, Department = @Department, Specialization = @Specialization, Email = @Email, BloodType = @BloodType, Gender = @Gender, CallNumber = @PhoneNumber, NationalId = @NationalId, DateOfBirth = @DateOfBirth WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", model.Id);
                cmd.Parameters.AddWithValue("@Firstname", model.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", model.Lastname);
                cmd.Parameters.AddWithValue("@Department", model.Department);
                cmd.Parameters.AddWithValue("@Specialization", model.Specialization);
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@BloodType", model.BloodType);
                cmd.Parameters.AddWithValue("@Gender", model.Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                cmd.Parameters.AddWithValue("@NationalId", model.NationalId);
                cmd.Parameters.AddWithValue("@DateOfBirth", model.DateOfBirth);
                cmd.Parameters.AddWithValue("@RegisterDate", model.RegisterDate);
                cmd.Parameters.AddWithValue("@Active", model.Active);
                cmd.Parameters.AddWithValue("@Deleted", model.Deleted);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
