using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace RememberMe
{
    internal class SQL
    {
        private static string conString = "Data Source=LAPTOP-NBLBTIGH\\SQLEXPRESS02;Initial Catalog=giris;Integrated Security=True;TrustServerCertificate=True;";
        private static SqlConnection connection = new SqlConnection(conString);

        public static void Connect()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message);
            }
        }

        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public static void InsertData(string name, string password)
        {
            try
            {
                string salt = Security.CreateNewRandomString();
                string encryptedPassword = Security.HashPassword(password, salt);

                string query = "INSERT INTO kaydol (name, password, salt) VALUES (@name, @password, @salt)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@password", encryptedPassword);
                    cmd.Parameters.AddWithValue("@salt", salt);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert data: " + ex.Message);
            }
        }

        public static bool ValidateLogin(string name, string password)
        {
            bool isValid = false;

            try
            {
                string storedPassword = "";
                string storedSalt = GetSalt(name);

                // Hash the password provided during login with the stored salt
                string hashedPassword = Security.HashPassword(password, storedSalt);

                string query = "SELECT password FROM kaydol WHERE name = @name";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            storedPassword = reader["password"].ToString();

                            // Compare hashed passwords
                            if (hashedPassword == storedPassword)
                            {
                                isValid = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to validate login: " + ex.Message);
            }

            return isValid;
        }

        public static string GetSalt(string name)
        {
            try
            {
                string query = "SELECT salt FROM kaydol WHERE name = @name";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string salt = reader["salt"].ToString();
                            return salt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get salt: " + ex.Message);
            }

            return "";
        }
        public static void AddMember(string name, string phone, string address)
        {
            try
            {
                string query = "INSERT INTO Members (name, phone, address) VALUES (@name, @phone, @address)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert data: " + ex.Message);
            }
        }
        //***************************************************************************
        public static DataTable ListMembers()
        {
            DataTable books = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Members";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(books);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search books by genre: " + ex.Message);
            }
            return books;
        }
        public static DataTable SearchMembersByName(string name)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = "SELECT id, name FROM Members WHERE name LIKE @name";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {

                        adapter.Fill(dataTable);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search members: " + ex.Message);
            }
            return dataTable;
        }

        public static void SearchBooks(string searchBook, DataGridView dataGridView)
        {
            try
            {
                string query = "SELECT * FROM Book WHERE Title LIKE @searchBook";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@searchBook", "%" + searchBook + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search books: " + ex.Message);
            }
        }
        public static void RefreshBorrowed(DataGridView dataGridView)
        {
            string query = "SELECT * FROM Borrow"; 
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }

        }
        public static List<string> GetGenres()
        {
            List<string> genres = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    string query = "SELECT DISTINCT Genre FROM Book";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        genres.Add(reader["Genre"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get genres: " + ex.Message);
            }
            return genres;
        }

        public static DataTable SearchBooksByGenre(string genre)
        {
            DataTable books = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Book WHERE Genre = @Genre";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(books);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search books by genre: " + ex.Message);
            }
            return books;
        }
        public static DataTable GetAllBooks()
        {
            DataTable books = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Book";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(books);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search books by genre: " + ex.Message);
            }
            return books;
        }

        public static void AddBook(string title, string author, string publisher, string genre)
        {
            try
            {
                string query = "INSERT INTO Book (Title, Author, Publisher, Genre) VALUES (@title, @author, @publisher, @genre)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@publisher", publisher);
                    cmd.Parameters.AddWithValue("@genre", genre);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert data: " + ex.Message);
            }
        }

        public static void DeleteRecord(int rank)
        {
            try
            {
                string query = "DELETE FROM Book WHERE Rank = @Rank";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Rank", rank);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public static void UpdateRanks()
        {
            string query = @"
                WITH OrderedRanks AS (
                    SELECT
                        Rank,
                        ROW_NUMBER() OVER (ORDER BY Rank) AS NewRank
                    FROM
                        Book
                )
                UPDATE Book
                SET Rank = OrderedRanks.NewRank
                FROM Book
                INNER JOIN OrderedRanks ON Book.Rank = OrderedRanks.Rank;
            ";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update ranks: " + ex.Message);
            }
        }

        public static void InsertBorrowRecord(int memberId, int bookId, DateTime startDate, DateTime endDate)
        {
            SQL.Connect();
            try
            {
                string query = "INSERT INTO Borrow (Member_id, Book_id, Start_Date, End_Date) VALUES (@Member_id, @Book_id, @Start_Date, @End_Date)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Member_id", memberId);
                    cmd.Parameters.AddWithValue("@Book_id", bookId);
                    cmd.Parameters.AddWithValue("@Start_Date", startDate);
                    cmd.Parameters.AddWithValue("@End_Date", endDate);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert borrow record: " + ex.Message);
            }
        }
        public static void SearchBorrowedBooks(DataGridView dgv)
        {
            try
            {
                string query = "SELECT br.id,b.Title, m.Name, br.Start_Date, br.End_Date " +
                               "FROM Borrow br " +
                               "JOIN Book b ON br.Book_id = b.Rank " +
                               "JOIN Members m ON br.Member_id = m.id";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgv.DataSource = dataTable;
                        dgv.Columns[0].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search borrowed books: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public static DataTable BindToGrid(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return dataTable;
        }

        //public static void DeleteBorrowedRecord(int id)
        //{
        //    try
        //    {
        //        using (SqlCommand command = new SqlCommand("DELETE FROM Borrow WHERE id = @id", connection))
        //        {
        //            command.Parameters.AddWithValue("@id", id);
        //            command.ExecuteNonQuery();
        //            MessageBox.Show("Record deleted successfully.");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //}
        public static void DeleteBorrowedRecord(int id)
        {
            try
            {
                string query = "DELETE FROM Borrow WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
