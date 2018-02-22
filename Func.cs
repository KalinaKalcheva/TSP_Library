using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace Library1
{
    class Func
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\КАЛИНА\UNI\6_SEMESTER\TSP_Project\Library1\Library1.accdb");
            command = connection.CreateCommand();
        }
        public Func()
        {
            ConnectTo();
        }

        public void InsertBook(Book b)
        {
            try
            {
                //OleDbDataReader reader = null;
                command.CommandText = "INSERT INTO Books(Title, Author, Genre) VALUES (" + "'" + b.Title1 + "'" + "," + "'"
                                        + b.Author1 + "'" + "," + "'" + b.Genre1 + "'" + ")";
                command.CommandType = CommandType.Text;

                command.CommandType = CommandType.Text;
                //command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public void InsertReader(Reader r)
        {
            try
            {
                //OleDbDataReader reader = null;
                command.CommandText = "INSERT INTO Readers(FirstName, Surname, EMail, PhoneNumber) VALUES (" + "'" + r.FirstName1 + "'" + "," + "'"
                                                    + r.Surname1 + "'" + "," + "'" + r.EMail1 + "'" + "," + "'" + r.PhoneNumber1 + "'" + ")";
                command.CommandType = CommandType.Text;

                command.CommandType = CommandType.Text;
                //command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public void DeleteBook(Book b)
        {
            try
            {
                command.CommandText = "DELETE FROM Books where ID=" + b.ID1;
                command.CommandType = CommandType.Text;
                //command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void DeleteReader(Reader r)
        {
            try
            {
                command.CommandText = "DELETE FROM Readers where ID=" + r.ID1;
                command.CommandType = CommandType.Text;
                //command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Book> SearchtBookTitle(Book b)
        {
            List<Book> books = new List<Book>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Books WHERE Title= '" + b.Title1 + "'", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book bo = new Book();
                    bo.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    bo.Title1 = reader["Title"].ToString();
                    bo.Author1 = reader["Author"].ToString();
                    bo.Genre1 = reader["Genre"].ToString();


                    books.Add(bo);
                }
                return books;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }


        }

        public List<Book> SearchtBookAuthor(Book b)
        {
            List<Book> books = new List<Book>();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Books WHERE Author= '" + b.Author1 + "'", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book bo = new Book();
                    bo.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    bo.Title1 = reader["Title"].ToString();
                    bo.Author1 = reader["Author"].ToString();
                    bo.Genre1 = reader["Genre"].ToString();


                    books.Add(bo);
                }
                return books;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public List<Book> SearchtBookGenre(Book b)
        {
            List<Book> books = new List<Book>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Books WHERE Genre= '" + b.Genre1 + "'", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book bo = new Book();
                    bo.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    bo.Title1 = reader["Title"].ToString();
                    bo.Author1 = reader["Author"].ToString();
                    bo.Genre1 = reader["Genre"].ToString();


                    books.Add(bo);
                }
                return books;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public List<Reader> ListAllReaders()
        {
            List<Reader> readersList = new List<Reader>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Readers ", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Reader r = new Reader();
                    r.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    r.FirstName1 = reader["FirstName"].ToString();
                    r.Surname1 = reader["Surname"].ToString();
                    r.EMail1 = reader["EMail"].ToString();
                    r.PhoneNumber1 = reader["PhoneNUmber"].ToString();
                    r.Book1 = reader["Book"].ToString();

                    readersList.Add(r);
                }
                return readersList;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public List<Book> ListAllBooks()
        {
            List<Book> booksList=new List<Book>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Books ", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {   
                    Book b=new Book();
                    b.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    b.Title1 = reader["Title"].ToString();
                    b.Author1= reader["Author"].ToString();
                    b.Genre1 = reader["Genre"].ToString();


                    booksList.Add(b);
                }
                return booksList;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Reader> SearchReaderName(Reader re)
        {
            List<Reader> readersList = new List<Reader>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Readers WHERE FirstName='" + re.FirstName1 + "'", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Reader r = new Reader();
                    r.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    r.FirstName1 = reader["FirstName"].ToString();
                    r.Surname1 = reader["Surname"].ToString();
                    r.EMail1 = reader["EMail"].ToString();
                    r.PhoneNumber1 = reader["PhoneNUmber"].ToString();
                    r.Book1 = reader["Book"].ToString();

                    readersList.Add(r);
                }
                return readersList;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public List<Reader> SearchReaderSurname(Reader re)
        {
            List<Reader> readersList = new List<Reader>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Readers WHERE Surname='" + re.Surname1 + "'", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Reader r = new Reader();
                    r.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    r.FirstName1 = reader["FirstName"].ToString();
                    r.Surname1 = reader["Surname"].ToString();
                    r.EMail1 = reader["EMail"].ToString();
                    r.PhoneNumber1 = reader["PhoneNUmber"].ToString();
                    r.Book1 = reader["Book"].ToString();

                    readersList.Add(r);
                }
                return readersList;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public List<Reader> SearchReaderEmail(Reader re)
        {
            List<Reader> readersList = new List<Reader>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Readers WHERE EMail='" + re.EMail1 + "'", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Reader r = new Reader();
                    r.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    r.FirstName1 = reader["FirstName"].ToString();
                    r.Surname1 = reader["Surname"].ToString();
                    r.EMail1 = reader["EMail"].ToString();
                    r.PhoneNumber1 = reader["PhoneNUmber"].ToString();
                    r.Book1 = reader["Book"].ToString();

                    readersList.Add(r);
                }
                return readersList;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public List<Reader> SearchReaderNumber(Reader re)
        {
            List<Reader> readersList = new List<Reader>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Readers WHERE PhoneNumber='" + re.PhoneNumber1 + "'", connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Reader r = new Reader();
                    r.ID1 = Convert.ToInt32(reader["ID"].ToString());
                    r.FirstName1 = reader["FirstName"].ToString();
                    r.Surname1 = reader["Surname"].ToString();
                    r.EMail1 = reader["EMail"].ToString();
                    r.PhoneNumber1 = reader["PhoneNUmber"].ToString();
                    r.Book1 = reader["Book"].ToString();

                    readersList.Add(r);
                }
                return readersList;
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public void RentBook(Book b,Reader r)
        {

        }

    }
}
       

