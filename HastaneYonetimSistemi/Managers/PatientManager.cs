using HastaneYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimSistemi.Managers
{
    //interface (Arabirim) nesne türü: Sadece kalıtım benzeri eklenebilen, kod işletme özelliği bulunmayan, sınıfların şablonalarını sağlayan zorunlu alanları belirleyen kısıtlayıcı yapılardır. Hiç bir elemanı erişim belirleyici almaz, kod bloğu taşıyamaz, sadece metotların isimlerini taşır.
    public interface IPatientManager
    {
        void Create(NewPatientModel model);
        NewPatientModel ReadOne(int Id);
        List<NewPatientModel> ReadAll();
        void Update(NewPatientModel model);
        void Delete(int Id);
    }

    //arabirim implementasyonu:
    public class PatientManager : IPatientManager
    {
        private string connectionString;
        public PatientManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
        }

        public void Create(NewPatientModel model)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Patient (RegisterDate, Active, Deleted, Firstname, Lastname, Address, City, District, BloodType, Gender, PhoneNumber, NationalId, DateOfBirth) VALUES (@RegisterDate, @Active, @Deleted, @Firstname, @Lastname, @Address, @City, @District, @BloodType, @Gender, @PhoneNumber, @NationalId, @DateOfBirth)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Firstname", model.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", model.Lastname);
                cmd.Parameters.AddWithValue("@Address", model.Address);
                cmd.Parameters.AddWithValue("@City", model.City);
                cmd.Parameters.AddWithValue("@District", model.District);
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
            throw new NotImplementedException();
        }

        public List<NewPatientModel> ReadAll()
        {
            List<NewPatientModel> result = new List<NewPatientModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Patient";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new NewPatientModel
                        {
                            Id = reader.GetInt32(0),
                            RegisterDate = reader.GetDateTime(1),
                            Active = reader.GetBoolean(2),
                            Deleted = reader.GetBoolean(3),
                            Firstname = reader.GetString(4),
                            Lastname = reader.GetString(5),
                            Address = reader.GetString(6),
                            City = reader.GetString(7),
                            District = reader.GetString(8),
                            BloodType = reader.GetString(9),
                            Gender = reader.GetString(10),
                            PhoneNumber = reader.GetInt64(11),
                            NationalId = reader.GetInt64(12),
                            DateOfBirth = reader.GetDateTime(13)
                        });
                    }
                }
            }
            return result;
        }

        public NewPatientModel ReadOne(int Id)
        {
            NewPatientModel result = new NewPatientModel();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Patient WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = new NewPatientModel()
                        {
                            Id = reader.GetInt32(0),
                            RegisterDate = reader.GetDateTime(1),
                            Active = reader.GetBoolean(2),
                            Deleted = reader.GetBoolean(3),
                            Firstname = reader.GetString(4),
                            Lastname = reader.GetString(5),
                            Address = reader.GetString(6),
                            City = reader.GetString(7),
                            District = reader.GetString(8),
                            BloodType = reader.GetString(9),
                            Gender = reader.GetString(10),
                            PhoneNumber = reader.GetInt64(11),
                            NationalId = reader.GetInt64(12),
                            DateOfBirth = reader.GetDateTime(13)
                        };
                    }
                }
            }

            return result;
        }

        public void Update(NewPatientModel model)
        {
            throw new NotImplementedException();
        }
    }
}
