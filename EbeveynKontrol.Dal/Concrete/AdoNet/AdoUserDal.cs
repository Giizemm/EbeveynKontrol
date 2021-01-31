using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbeveynKontrol.Dal.Abstract;
using EbeveynKontrol.Dal.Concrete.AdoNet.Context;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.Dal.Concrete.AdoNet
{
    public class AdoUserDal : IUserDal
    {
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM [User]", connection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    users.Add(new User()
                    {
                        Id = sqlDataReader.GetInt32(0),
                        Name = sqlDataReader.GetString(1),
                        Password = sqlDataReader.GetString(2)
                    });
                }
                connection.Close();
                return users;
            }
        }

        public User Get(int id)
        {
            User user = new User();
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM [User] WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    user.Id = sqlDataReader.GetInt32(0);
                    user.Name = sqlDataReader.GetString(1);
                    user.Password = sqlDataReader.GetString(2);
                }
                connection.Close();
                return user;

            }
        }

        public bool Add(User user)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO [User] VALUES(@name,@password)", connection);
                sqlCommand.Parameters.AddWithValue("@name", user.Name);
                sqlCommand.Parameters.AddWithValue("@password", user.Password);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;

            }
        }

        public bool Delete(User user)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"DELETE FROM [User] WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@id", user.Id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;

            }
        }

        public bool Delete(int id)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"DELETE FROM [User] WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@id", id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;

            }
        }

        public bool Update(User user)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"UPDATE [User] SET Name=@name,Password=@password WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@name", user.Name);
                sqlCommand.Parameters.AddWithValue("@password", user.Password);
                sqlCommand.Parameters.AddWithValue("@id", user.Id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;

            }
        }
    }
}
