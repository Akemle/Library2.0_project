using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper; // utilizando o Dapper 
using Library2._0;

namespace Library2._0.AcessMethods
{
    public class LibraryAccess
    {
        //Filtrar Livros
        public List<Book> GetBooks(string author_name)
        {
            // Filtrando os valores pedidos para serem mostrados 
            // utilizando o USING para garantir o encerrameto da conexão
            using (IDbConnection connection = new SqlConnection(LibraryConnection.Conn("LibraryDB")))
            {
                var output = connection.Query<Book>($"SELECT * FROM Books WHERE book_author = '{author_name}'").ToList();
                    return output; 
            }

        }

        //Adicionar Livros
        public void AddBook(int book_id, string book_name, float book_price, int book_quant, string book_author)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(LibraryConnection.Conn("LibraryDB")))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        string query = $"INSERT INTO Books VALUES (@id, @name, @price, @quant, @author)";

                        SqlCommand cmd = new SqlCommand(query, connection, transaction);
                        cmd.Parameters.AddWithValue("@id", book_id);
                        cmd.Parameters.AddWithValue("@name", book_name);
                        cmd.Parameters.AddWithValue("@price", book_price);
                        cmd.Parameters.AddWithValue("@quant", book_quant);
                        cmd.Parameters.AddWithValue("@author", book_author);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
            }
            catch(SqlException)
            {
                throw;
            } 
        }    
        
        public void UpdateBook(int book_id, string book_name, float book_price, int book_quant, string book_author)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(LibraryConnection.Conn("LibraryDB")))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        string query = $"UPDATE Books SET book_name = '{book_name}' WHERE book_id = '{book_id}'" +
                            $"UPDATE Books SET book_price = '{book_price}' WHERE book_id = '{book_id}'" +
                            $"UPDATE Books SET book_quant = '{book_quant}' WHERE book_id = '{book_id}'" +
                            $"UPDATE Books SET book_author = '{book_author}' WHERE book_id = '{book_id}'"
                            ;

                        SqlCommand cmd = new SqlCommand(query, connection, transaction);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

        }


        public void DeleteBook(int book_id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(LibraryConnection.Conn("LibraryDB")))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        string query = $"DELETE FROM Books WHERE book_id = '{book_id}'";

                        SqlCommand cmd = new SqlCommand(query, connection, transaction);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

        }
    }
}
