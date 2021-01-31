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
    public class AdoMailDal:IMailDal
    {
        public List<Mail> GetAll()
        {
            List<Mail> mails=new List<Mail>();
            using (var connection=SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand=new SqlCommand(@"SELECT * FROM Mail",connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    mails.Add(new Mail()
                    {
                        Id = (int) sqlDataReader["Id"],
                        Adress = sqlDataReader["Adress"].ToString()
                    });
                }
                connection.Close();
                return mails;

            }
        }

        public Mail Get(int id)
        {
            Mail mail=new Mail();
            using (var connection=SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand=new SqlCommand(@"SELECT * FROM [Mail] WHERE Id=@id",connection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    mail.Id = (int) sqlDataReader["Id"];
                    mail.Adress = sqlDataReader.ToString();
                }

                connection.Close();
                return mail;

            }
        }

        public bool Add(Mail mail)
        {
            using (var connection=SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand=new SqlCommand(@"INSERT INTO [Mail] VALUES(@adress)",connection);
                sqlCommand.Parameters.AddWithValue("@adress", mail.Adress);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;

            }
        }

        public bool Delete(Mail mail)
        {
            using (var connection=SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand=new SqlCommand(@"DELETE FROM [Mail] WHERE Id = @id",connection);
                sqlCommand.Parameters.AddWithValue("@id", mail.Id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"DELETE FROM[Mail] WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        public bool Update(Mail mail)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"UPDATE [Mail] SET Adress=@adress WHERE Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@adress", mail.Adress);
                sqlCommand.Parameters.AddWithValue("@id", mail.Id);

                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
    }
}
