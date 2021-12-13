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
                string str = "select * from nguoidung where quyen_id='1'";
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
                            gioitinh=reader["gioitinh"].ToString(),
                            ngaysinh= Convert.ToDateTime(reader["ngaysinh"]),
                            id_card = reader["id_card"].ToString(),
                            sodienthoai=reader["sodienthoai"].ToString(),

                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<thuexe> Getthuexe()
        {
            List<thuexe> list = new List<thuexe>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from thuexe tx, ctthuexe ct where tx.id=ct.id ";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new thuexe()
                        {
                            id = reader["id"].ToString(),
                            nsd_id = reader["nsd_id"].ToString(),
                            xe_id = reader["xe_id"].ToString(),
                            email = reader["email"].ToString(),
                            tongtien = Convert.ToInt32(reader["tongtien"]),
                            trangthai = reader["trangthai"].ToString(),
                            batdau = Convert.ToDateTime(reader["batdau"]),
                            ketthuc = Convert.ToDateTime(reader["ketthuc"]),
                            thanhtoan = reader["thanhtoan"].ToString(),
                            sodienthoai = reader["sodienthoai"].ToString(),

                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<thuexe> Timthuexe(string id)
        {
            List<thuexe> list = new List<thuexe>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from thuexe tx, ctthuexe ct where tx.id=ct.id and tx.id=@id ";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new thuexe()
                        {
                            id = reader["id"].ToString(),
                            nsd_id = reader["nsd_id"].ToString(),
                            xe_id = reader["xe_id"].ToString(),
                            email = reader["email"].ToString(),
                            tongtien = Convert.ToInt32(reader["tongtien"]),
                            trangthai = reader["trangthai"].ToString(),
                            batdau = Convert.ToDateTime(reader["batdau"]),
                            ketthuc = Convert.ToDateTime(reader["ketthuc"]),
                            thanhtoan = reader["thanhtoan"].ToString(),
                            sodienthoai = reader["sodienthoai"].ToString(),

                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<thuonghieu> Gethangxe()
        {
            List<thuonghieu> list = new List<thuonghieu>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from thuonghieu";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new thuonghieu()
                        {
                            id = reader["id"].ToString(),
                            tenth = reader["tenth"].ToString(),
                            quocgia = reader["quocgia"].ToString(),
                            
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<thuonghieu> Timhangxe(string id)
        {
            List<thuonghieu> list = new List<thuonghieu>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from thuonghieu where id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new thuonghieu()
                        {
                            id = reader["id"].ToString(),
                            tenth = reader["tenth"].ToString(),
                            quocgia = reader["quocgia"].ToString(),

                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<nguoidung> Timthanhvien(string id)
        {
            List<nguoidung> list = new List<nguoidung>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from nguoidung where id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
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
                            gioitinh = reader["gioitinh"].ToString(),
                            ngaysinh = Convert.ToDateTime(reader["ngaysinh"]),
                            id_card = reader["id_card"].ToString(),
                            sodienthoai = reader["sodienthoai"].ToString(),

                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int[] Xoanguoidung(string makh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var queryCTHD = "delete from ctthuexe where id IN (select distinct id from thuexe HD where HD.nsd_id=@makh) or id in (select distinct tx.id from thuexe tx,xe where tx.xe_id=xe.id and csh_id=@makh)";
                MySqlCommand cmd1 = new MySqlCommand(queryCTHD, conn);
                cmd1.Parameters.AddWithValue("makh", makh);

                var queryHOPDONG = "delete from thuexe where nsd_id=@makh or xe_id in (select distinct id from xe where csh_id=@makh)";
                MySqlCommand cmd2 = new MySqlCommand(queryHOPDONG, conn);
                cmd2.Parameters.AddWithValue("makh", makh);

                var queryKHACHHANG = "delete from nguoidung where id=@makh";
                MySqlCommand cmd3 = new MySqlCommand(queryKHACHHANG, conn);
                cmd3.Parameters.AddWithValue("makh", makh);
                int[] deleted = new int[3];
                deleted[0] = cmd1.ExecuteNonQuery();
                deleted[1] = cmd2.ExecuteNonQuery();
                deleted[2] = cmd3.ExecuteNonQuery();
                return deleted;
            }
        }
        public int[] Xoahangxe(string makh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var queryCTHD = "delete from ctthuexe where id  in (select distinct tx.id from thuexe tx,xe where tx.xe_id=xe.id and thuonghieu=@makh)";
                MySqlCommand cmd1 = new MySqlCommand(queryCTHD, conn);
                cmd1.Parameters.AddWithValue("makh", makh);

                var queryHOPDONG = "delete from thuexe where  xe_id in (select distinct id from xe where thuonghieu=@makh)";
                MySqlCommand cmd2 = new MySqlCommand(queryHOPDONG, conn);
                cmd2.Parameters.AddWithValue("makh", makh);

                var queryKHACHHANG = "delete from xe where thuonghieu=@makh";
                MySqlCommand cmd3 = new MySqlCommand(queryKHACHHANG, conn);
                cmd3.Parameters.AddWithValue("makh", makh);
                var queryKHACHHANG1 = "delete from thuonghieu where id=@makh";
                MySqlCommand cmd4 = new MySqlCommand(queryKHACHHANG1, conn);
                cmd3.Parameters.AddWithValue("makh", makh);
                int[] deleted = new int[3];
                deleted[0] = cmd1.ExecuteNonQuery();
                deleted[1] = cmd2.ExecuteNonQuery();
                deleted[2] = cmd3.ExecuteNonQuery();
                deleted[3] = cmd4.ExecuteNonQuery();
                return deleted;
            }
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