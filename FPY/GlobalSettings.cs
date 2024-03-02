using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPY.Properties;
using FPY; 

namespace FPY
{
    internal class GlobalSettings

    {

        public static List<string> getDanhSachDatabase()

        {

            using (var db = new FPYEntities())

            {

                return db.Database.SqlQuery<string>("SELECT name FROM sys.databases").ToList();

            }

        }

        public static string ConnectionString { get; set; }









        /// <summary>

        /// Đại diện cho tên server

        /// </summary>

        public static string ServerName { get; set; }



        /// <summary>

        /// Đại diện cho tên database

        /// </summary>

        public static string ServerCatalog { get; set; }



        /// <summary>

        /// Lấy danh sách database

        /// </summary>

        /// <param name="connectionString">Chuỗi kết nối đến master</param>

        /// <returns></returns>

        public static List<string> GetDatabaseList(string connectionString)

        {

            List<string> list = new List<string>();



            using (SqlConnection con = new SqlConnection(connectionString))

            {

                con.Open();



                using (SqlCommand cmd = new SqlCommand("sp_databases", con)) //sp_databases là một stored procedure có sẵn trong SQL Server

                using (IDataReader dr = cmd.ExecuteReader())

                    while (dr.Read())

                        list.Add(dr[0].ToString());

            }



            return list;

        }



        /// <summary>

        /// Lưu lại kết nối cơ sở dữ liệu

        /// </summary>

        public static void SaveDatabaseConnection()

        {

            Settings.Default.ConnectionString = ConnectionString;

            Settings.Default.Database_ServerName = ServerName;

            Settings.Default.Database_ServerCatalog = ServerCatalog;



            Settings.Default.Save();

        }

        /// <summary>

        /// Get UserName

        /// </summary>

        /// <returns></returns>

        public static string GetUserName()

        {

            return Settings.Default.Login_UserName;

        }

    }
}
