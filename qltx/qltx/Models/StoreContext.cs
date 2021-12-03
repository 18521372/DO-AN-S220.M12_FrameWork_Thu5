using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;


namespace qltx.Models
{
    internal class StoreContext
    {
        public string ConnectionString { get; set; }//biết thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<nguoidung> Getthanhvien()
        {
            List<nguoidung> list = new List<nguoidung>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from nguoidung";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new nguoidung()
                        {

                            id = reader["id"].ToString(),
                            ten = reader["ten"].ToString(),
                            email = reader["email"].ToString(),
                            diachi = reader["diachi"].ToString(),


                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int Timthanhvien(string email, string password)
        {
            List<nguoidung> list = new List<nguoidung>();
            int i = 0;
            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from nguoidung";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    string eml = "";
                    string pwd = "";
                    while (reader.Read())
                    {
                        eml = reader["email"].ToString();
                        pwd = reader["password"].ToString();
                        if (eml == email && password == pwd)
                        {
                            i = Convert.ToInt32(reader["quyen_id"]);
                            break;
                        }
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return i;
        }
    }
}