using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class DatabaseStorage : IAddressBookStorage
    {
        private string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=true;TrustServerCertificate=true;";

        public async Task SaveAsync(List<Contact> contacts)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            await con.OpenAsync();

            foreach (var contact in contacts)
            {
                string query = @"INSERT INTO Contacts 
                                (FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email)
                                VALUES (@FirstName, @LastName, @Address, @City, @State, @Zip, @Phone, @Email)";

                using SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
                cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                cmd.Parameters.AddWithValue("@Address", contact.Address);
                cmd.Parameters.AddWithValue("@City", contact.City);
                cmd.Parameters.AddWithValue("@State", contact.State);
                cmd.Parameters.AddWithValue("@Zip", contact.Zip);
                cmd.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", contact.Email);

                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<List<Contact>> LoadAsync()
        {
            List<Contact> contacts = new List<Contact>();

            using SqlConnection con = new SqlConnection(connectionString);
            await con.OpenAsync();

            string query = "SELECT * FROM Contacts";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                contacts.Add(new Contact
                {
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Address = reader["Address"].ToString(),
                    City = reader["City"].ToString(),
                    State = reader["State"].ToString(),
                    Zip = reader["Zip"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    Email = reader["Email"].ToString()
                });
            }

            return contacts;
        }
    }
}
