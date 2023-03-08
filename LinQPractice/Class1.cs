using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection string
            string connectionString = "Server=localhost;Database=mydatabase;Uid=root;Pwd=password;";

            // CREATE
            InsertRecord(connectionString);

            // READ
            ReadRecords(connectionString);

            // UPDATE
            UpdateRecord(connectionString);

            // DELETE
            DeleteRecord(connectionString);
        }

        static void InsertRecord(string connectionString)
        {
            // Insert a new record
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string insertSql = "INSERT INTO customers (name, email) VALUES ('John Doe', 'john.doe@example.com')";

                using (MySqlCommand command = new MySqlCommand(insertSql, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine("Inserted {0} record(s).", rowsAffected);
                }
            }
        }

        static void ReadRecords(string connectionString)
        {
            // Read all records
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectSql = "SELECT id, name, email FROM customers";

                using (MySqlCommand command = new MySqlCommand(selectSql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            string email = reader.GetString("email");

                            Console.WriteLine("{0}, {1}, {2}", id, name, email);
                        }
                    }
                }
            }
        }

        static void UpdateRecord(string connectionString)
        {
            // Update a record
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string updateSql = "UPDATE customers SET email = 'john.doe.new@example.com' WHERE id = 1";

                using (MySqlCommand command = new MySqlCommand(updateSql, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine("Updated {0} record(s).", rowsAffected);
                }
            }
        }

        static void DeleteRecord(string connectionString)
        {
            // Delete a record
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string deleteSql = "DELETE FROM customers WHERE id = 1";

                using (MySqlCommand command = new MySqlCommand(deleteSql, connection))
                {
                    int
