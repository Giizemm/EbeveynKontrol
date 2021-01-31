using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbeveynKontrol.Dal.Abstract;
using EbeveynKontrol.Dal.Concrete.AdoNet.Context;
using EbeveynKontrol.Entity;

namespace EbeveynKontrol.Dal.Concrete.AdoNet
{
    public class AdoBanDal : IBanDal
    {
        public List<Ban> GetAll()
        {
            List<Ban> bans = new List<Ban>();
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM Ban", connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    bans.Add(new Ban()
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString()
                    });

                }
                connection.Close();
                return bans;
            }
        }

        public Ban Get(int id)
        {
            Ban ban = new Ban();
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM [Ban] WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    ban.Id = (int)sqlDataReader[0];
                    ban.Name = sqlDataReader.ToString();
                }

                connection.Close();
                return ban;
            }
        }

        public bool Add(Ban ban)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO [Ban] VALUES(@name)", connection);
                sqlCommand.Parameters.AddWithValue("@name", ban.Name);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }

        }

        public bool Delete(Ban ban)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"DELETE FROM [Ban] WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@id", ban.Id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"DELETE FROM [Ban] WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@id", id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        public bool Update(Ban ban)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"UPDATE [Ban] SET Name=@name WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@name", ban.Name);
                sqlCommand.Parameters.AddWithValue("@id", ban.Id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
    }
}
