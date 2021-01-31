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
    public class AdoReportDal : IReportDal
    {
        public List<Report> GetAll()
        {
            List<Report> reports = new List<Report>();
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"SELECT Report.Id,Report.SiteTitle,Ban.[Name],Report.[DateTime] FROM Ban INNER JOIN Report ON (Ban.Id=Report.BanID)", connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    reports.Add(new Report()
                    {
                        Id = (int)sqlDataReader["Id"],
                        SiteTitle = sqlDataReader["SiteTitle"].ToString(),
                        DateTime = (DateTime)sqlDataReader["DateTime"],
                        Ban = new Ban()
                        {
                            Name = sqlDataReader["Name"].ToString()
                        }
                    });
                }

                connection.Close();
                return reports;
            }
        }

        public Report Get(int id)
        {
            Report report = new Report();
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"SELECT Report.Id,Report.SiteTitle,Ban.[Name],Report.[DateTime] FROM Ban INNER JOIN Report ON (Ban.Id=Report.BanID) WHERE Report.Id=@id", connection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    report.Id = (int)sqlDataReader["Id"];
                    report.SiteTitle = sqlDataReader["SiteTitle"].ToString();
                    report.DateTime = (DateTime)sqlDataReader["DateTime"];
                    report.Ban = new Ban()
                    {
                        Name = sqlDataReader["Name"].ToString()
                    };
                }
                connection.Close();
                return report;
            }
        }

        public bool Add(Report report)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO [Report] VALUES (@siteTitle,@dateTime,@banId)", connection);
                sqlCommand.Parameters.AddWithValue("@siteTitle", report.SiteTitle);
                sqlCommand.Parameters.AddWithValue("@dateTime", report.DateTime);
                sqlCommand.Parameters.AddWithValue("@banId", report.BanID);
                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        public bool Delete(Report report)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"DELETE FROM [Report] WHERE Id= @reportId", connection);
                sqlCommand.Parameters.AddWithValue("@reportId", report.Id);
                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"DELETE FROM [Report] WHERE Id= @reportId", connection);
                sqlCommand.Parameters.AddWithValue("@reportId",id);
                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        public bool Update(Report report)
        {
            using (var connection = SqlConnectionContext.Connection())
            {
                SqlCommand sqlCommand = new SqlCommand(@"UPDATE [Report] SET SiteTitle=@siteTitle,DateTime=@dateTime WHERE Id= @reportId", connection);
                sqlCommand.Parameters.AddWithValue("@siteTitle", report.SiteTitle);
                sqlCommand.Parameters.AddWithValue("@dateTime", report.DateTime);
                sqlCommand.Parameters.AddWithValue("@reportId", report.Id);
                int result = sqlCommand.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
    }
}
