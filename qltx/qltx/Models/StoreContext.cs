using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Session;
using System.Data;
/*using Newtonsoft.Json;*/

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
                            tenanh= reader["tenanh"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<xe> Getxe(string id)
        {
            List<xe> list = new List<xe>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from xe where csh_id!=@id";

                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new xe()
                        {
                            id = reader["id"].ToString(),
                            csh_id = reader["csh_id"].ToString(),
                            tenxe = reader["tenxe"].ToString(),
                            thuonghieu = reader["thuonghieu"].ToString(),
                            vitri = reader["vitri"].ToString(),
                            giathue = Convert.ToInt32(reader["giathue"]),
                            bienso = reader["bienso"].ToString(),
                            ngaythue = Convert.ToDateTime(reader["ngaythue"]),
                            trangthai_id = reader["trangthai_id"].ToString(),
                            loainhienlieu = reader["loainhienlieu"].ToString(),
                            tenanh = reader["img"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<xe> getxe()
        {
            List<xe> list = new List<xe>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from xe ";

                MySqlCommand cmd = new MySqlCommand(str, conn);
            
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new xe()
                        {
                            id = reader["id"].ToString(),
                            csh_id = reader["csh_id"].ToString(),
                            tenxe = reader["tenxe"].ToString(),
                            thuonghieu = reader["thuonghieu"].ToString(),
                            vitri = reader["vitri"].ToString(),
                            giathue = Convert.ToInt32(reader["giathue"]),
                            bienso = reader["bienso"].ToString(),
                            ngaythue = Convert.ToDateTime(reader["ngaythue"]),
                            trangthai_id = reader["trangthai_id"].ToString(),
                            loainhienlieu = reader["loainhienlieu"].ToString(),
                            tenanh = reader["img"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<xe> GetxeCuaNguoiDung(string i)
        {
            List<xe> list = new List<xe>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from xe where csh_id=@id";
                
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", i);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new xe()
                        {
                            id = reader["id"].ToString(),
                            csh_id = reader["csh_id"].ToString(),
                            tenxe = reader["tenxe"].ToString(),
                            thuonghieu = reader["thuonghieu"].ToString(),
                            vitri = reader["vitri"].ToString(),
                            giathue = Convert.ToInt32(reader["giathue"]),
                            bienso = reader["bienso"].ToString(),
                            ngaythue = Convert.ToDateTime(reader["ngaythue"]),
                            trangthai_id = reader["trangthai_id"].ToString(),
                            loainhienlieu = reader["loainhienlieu"].ToString(),

                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<xe> Timxe(string id)
        {
            List<xe> list = new List<xe>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from xe where  id =@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new xe()
                        {
                            id = reader["id"].ToString(),
                            csh_id = reader["csh_id"].ToString(),
                            tenxe = reader["tenxe"].ToString(),
                            thuonghieu = reader["thuonghieu"].ToString(),
                            vitri = reader["vitri"].ToString(),
                            giathue = Convert.ToInt32(reader["giathue"]),
                            bienso = reader["bienso"].ToString(),
                            ngaythue = Convert.ToDateTime(reader["ngaythue"]),
                            trangthai_id = reader["trangthai_id"].ToString(),
                            loainhienlieu = reader["loainhienlieu"].ToString(),

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

        internal int UpdateXe(xe xcnd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update xe set   tenxe=@tenxe,  vitri=@vitri, bienso=@bienso, giathue=@giathue, ngaythue=@ngaythue, trangthai_id=@trangthai_id, loainhienlieu=@loainhienlieu where id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", xcnd.id);
                cmd.Parameters.AddWithValue("tenxe",xcnd.tenxe);             
                cmd.Parameters.AddWithValue("vitri", xcnd.vitri);
                cmd.Parameters.AddWithValue("bienso", xcnd.bienso);
                cmd.Parameters.AddWithValue("giathue", xcnd.giathue);
                cmd.Parameters.AddWithValue("ngaythue", xcnd.ngaythue);
                cmd.Parameters.AddWithValue("trangthai_id", xcnd.trangthai_id);
                cmd.Parameters.AddWithValue("loainhienlieu", xcnd.loainhienlieu);
                return (cmd.ExecuteNonQuery());
            }
        }
        internal int InsertXe(xe xcnd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into xe values(@id,@csh_id,@tenxe,@thuonghieu,@vitri,@bienso,@giathue,@ngaythue,@trangthai_id,@loainhienlieu,'')";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                string str2 = "select count(*) as soxe from xe ";
                MySqlCommand cmd2 = new MySqlCommand(str2, conn);
                int id=0;
                using (var reader = cmd2.ExecuteReader())
                {
                    if (reader.Read()) { id = Convert.ToInt32(reader["soxe"]); }
                }
                int v = id+1;
                cmd.Parameters.AddWithValue("id", "XE00"+v);
                cmd.Parameters.AddWithValue("csh_id", xcnd.csh_id);
                cmd.Parameters.AddWithValue("tenxe", xcnd.tenxe);
                cmd.Parameters.AddWithValue("thuonghieu", xcnd.thuonghieu);
                cmd.Parameters.AddWithValue("vitri", xcnd.vitri);
                cmd.Parameters.AddWithValue("bienso", xcnd.bienso);
                cmd.Parameters.AddWithValue("giathue", xcnd.giathue);
                cmd.Parameters.AddWithValue("ngaythue", DateTime.Today);
                cmd.Parameters.AddWithValue("trangthai_id", xcnd.trangthai_id);
                cmd.Parameters.AddWithValue("loainhienlieu", xcnd.loainhienlieu);
                return (cmd.ExecuteNonQuery());
            }
        }
        internal int InsertThueXe(thuexe hdcnd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var str = "insert into thuexe values(@id,@nsd_id,@xe_id)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                string str2 = "select count(*) as sothuexe from thuexe ";
                MySqlCommand cmd2 = new MySqlCommand(str2, conn);
                int id = 0;
                using (var reader = cmd2.ExecuteReader())
                {
                    if (reader.Read()) { id = Convert.ToInt32(reader["sothuexe"]); }
                }
                cmd.Parameters.AddWithValue("id", "THUE" + id);
                cmd.Parameters.AddWithValue("nsd_id", hdcnd.nsd_id);
                cmd.Parameters.AddWithValue("xe_id", hdcnd.xe_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    var str3 = "insert into ctthuexe values(@id,@sodienthoai,@email,@batdau,@ketthuc,@trangthai,@tongtien,@thanhtoan)";
                    MySqlCommand cmd3 = new MySqlCommand(str3, conn);
                    cmd3.Parameters.AddWithValue("id", "THUE" + id);
                    cmd3.Parameters.AddWithValue("sodienthoai", hdcnd.sodienthoai);
                    cmd3.Parameters.AddWithValue("email", hdcnd.email);
                    cmd3.Parameters.AddWithValue("batdau", hdcnd.batdau);
                    cmd3.Parameters.AddWithValue("ketthuc", hdcnd.ketthuc);
                    cmd3.Parameters.AddWithValue("trangthai", hdcnd.trangthai);
                    cmd3.Parameters.AddWithValue("tongtien", hdcnd.tongtien);
                    cmd3.Parameters.AddWithValue("thanhtoan", hdcnd.thanhtoan);
                    return (cmd3.ExecuteNonQuery());
                }
                else return 0;
            }
        }

        internal int InsertanhXe(string id, string ten)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update xe set img=@ten where id =(SELECT id FROM xe where csh_id=@id ORDER BY id DESC LIMIT 1)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("ten",ten);
                
                return (cmd.ExecuteNonQuery());
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
                int[] deleted = new int[4];
                deleted[0] = cmd1.ExecuteNonQuery();
                deleted[1] = cmd2.ExecuteNonQuery();
                deleted[2] = cmd3.ExecuteNonQuery();
                deleted[3] = cmd4.ExecuteNonQuery();
                return deleted;
            }
        }

        public int[] Xoaxe(string makh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var queryCTHD = "delete from ctthuexe where id  in (select distinct id from thuexe  where xe_id=@makh)";
                MySqlCommand cmd1 = new MySqlCommand(queryCTHD, conn);
                cmd1.Parameters.AddWithValue("makh", makh);

                var queryHOPDONG = "delete from thuexe where  xe_id =@makh";
                MySqlCommand cmd2 = new MySqlCommand(queryHOPDONG, conn);
                cmd2.Parameters.AddWithValue("makh", makh);

                var queryKHACHHANG = "delete from xe where id=@makh";
                MySqlCommand cmd3 = new MySqlCommand(queryKHACHHANG, conn);
                cmd3.Parameters.AddWithValue("makh", makh);
               
                int[] deleted = new int[3];
                deleted[0] = cmd1.ExecuteNonQuery();
                deleted[1] = cmd2.ExecuteNonQuery();
                deleted[2] = cmd3.ExecuteNonQuery();           
                return deleted;
            }
        }
        public nguoidung Timthanhvien(string email, string password)
        {
            nguoidung list = new nguoidung();
            
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
                    string id = "";
                    while (reader.Read())
                    {
                        eml = reader["email"].ToString();
                        pwd = reader["password"].ToString();
                        id = reader["id"].ToString();
                        if (eml == email && password == pwd)
                        {
                            list.quyen = Convert.ToInt32(reader["quyen_id"]);
                            list.id = reader["id"].ToString();

                            break;
                        }
                    }
                    reader.Close();
                    if (eml == email && password == pwd)
                    {
                        string str1 = "update dangnhap set mand=@id";
                        MySqlCommand cmd1 = new MySqlCommand(str1, conn);
                        cmd1.Parameters.AddWithValue("id", id);
                        cmd1.ExecuteNonQuery();
                    }

                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<chart> Getsoluongxe()
        {
            List<chart> list = new List<chart>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT month(batdau) as thang,COUNT(*) as tong FROM ctthuexe GROUP by month(batdau)";
                MySqlCommand cmd = new MySqlCommand(str, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new chart()
                        {
                            row = Convert.ToInt32(reader["thang"]),
                            col = Convert.ToInt32(reader["tong"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<chart> Getdoanhso()
        {
            List<chart> list = new List<chart>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT month(batdau) as thang,sum(tongtien) as tong FROM ctthuexe GROUP by month(batdau)";
                MySqlCommand cmd = new MySqlCommand(str, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new chart()
                        {
                            row = Convert.ToInt32(reader["thang"]),
                            col = Convert.ToInt32(reader["tong"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<nguoidung> thuenhieunhat()
        {
            List<nguoidung> list = new List<nguoidung>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT nd.id, ten, email, diachi,gioitinh, ngaysinh,id_card, sodienthoai ,COUNT(*) as solanthue FROM thuexe tx, nguoidung nd WHERE nsd_id=nd.id GROUP by nsd_id ORDER by COUNT(*) DESC limit 5";
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
                            gioitinh = reader["gioitinh"].ToString(),
                            ngaysinh = Convert.ToDateTime(reader["ngaysinh"]),
                            id_card = reader["id_card"].ToString(),
                            sodienthoai = reader["sodienthoai"].ToString(),
                            quyen=Convert.ToInt32(reader["solanthue"]),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int tongxe()
        {

            int tongxe = 0 ;
            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT COUNT(*) as tongxe FROM xe";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tongxe = Convert.ToInt32(reader["tongxe"]);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return tongxe;
        }
        public int tongxedt()
        {

            int tongxe = 0;
            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT COUNT(*) as tongxe FROM ctthuexe WHERE trangthai='dt'";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tongxe = Convert.ToInt32(reader["tongxe"]);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return tongxe;
        }
        public int tongnd()
        {

            int tongxe = 0;
            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=qlsv;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT COUNT(*) as tongxe FROM nguoidung";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tongxe = Convert.ToInt32(reader["tongxe"]);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return tongxe;
        }

        public int ThemUser(nguoidung nd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into nguoidung values(@id, @ten, @email, @diachi, @gioitinh, @ngaysinh, @idcard, @password, @sdt, @quyen)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", nd.id);
                cmd.Parameters.AddWithValue("ten", nd.ten);
                cmd.Parameters.AddWithValue("email", nd.email);
                cmd.Parameters.AddWithValue("diachi", nd.diachi);
                cmd.Parameters.AddWithValue("gioitinh", nd.gioitinh);
                cmd.Parameters.AddWithValue("ngaysinh", nd.ngaysinh);
                cmd.Parameters.AddWithValue("idcard", nd.id_card);
                cmd.Parameters.AddWithValue("password", nd.password);
                cmd.Parameters.AddWithValue("sdt", nd.sodienthoai);
                cmd.Parameters.AddWithValue("quyen", 1);
                return (cmd.ExecuteNonQuery());

            }
        }

        public nguoidung ViewUser(string Id)
        {
            nguoidung nd = new nguoidung();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select ten, diachi, email, sodienthoai, gioitinh, id from nguoidung where id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", Id);
                var reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nd.ten = reader.GetString(0);
                        nd.diachi = reader.GetString(1);
                        nd.email = reader.GetString(2);
                        nd.sodienthoai = reader.GetString(3);
                        nd.gioitinh = reader.GetString(4);
                        nd.id = reader.GetString(5);
                    }
                }
            }
            return nd;
        }

        public int UpdateUser(nguoidung nd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update nguoidung set ten=@ten, diachi=@diachi, email=@email, gioitinh=@gioitinh, sodienthoai=@sdt where id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ten", nd.ten);
                cmd.Parameters.AddWithValue("diachi", nd.diachi);
                cmd.Parameters.AddWithValue("email", nd.email);
                cmd.Parameters.AddWithValue("gioitinh", nd.gioitinh);
                cmd.Parameters.AddWithValue("sdt", nd.sodienthoai);
                cmd.Parameters.AddWithValue("id", nd.id);
                return (cmd.ExecuteNonQuery());
            }
        }

        public List<object> ViewHopDong(string Id)
        {
            List<object> list = new List<object>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string str = "SELECT nguoidung.id, tenxe, loainhienlieu, vitri, batdau, ketthuc, motta FROM nguoidung, thuexe, ctthuexe, xe, trangthaithue WHERE nguoidung.id = thuexe.nsd_id AND thuexe.xe_id = xe.id AND thuexe.id = ctthuexe.id AND ctthuexe.trangthai = trangthaithue.id AND nguoidung.id=@id;";

                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ob = new {
                            tenxe = reader["tenxe"].ToString(),
                            loainhienlieu = reader["loainhienlieu"].ToString(),
                            vitri = reader["vitri"].ToString(),
                            batdau = Convert.ToDateTime(reader["batdau"]),
                            ketthuc = Convert.ToDateTime(reader["ketthuc"]),
                            motta = reader["motta"].ToString(),
                            id = reader["id"].ToString()
                        };
                        list.Add(ob);

                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
      
        public int UpdateThuexe(thuexe nd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update ctthuexe set sodienthoai=@sdt, batdau=@batdau, email=@email, ketthuc=@ketthuc, trangthai=@trangthai where id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("sdt", nd.sodienthoai);
                cmd.Parameters.AddWithValue("batdau", nd.batdau);
                cmd.Parameters.AddWithValue("email", nd.email);
                cmd.Parameters.AddWithValue("ketthuc", nd.ketthuc);
                cmd.Parameters.AddWithValue("trangthai", nd.trangthai);
                cmd.Parameters.AddWithValue("id", nd.id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int Updatethuonghieu(thuonghieu th)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update thuonghieu set tenth=@tenth, quocgia=@quocgia where id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tenth", th.tenth);
                cmd.Parameters.AddWithValue("quocgia", th.quocgia);               
                cmd.Parameters.AddWithValue("id", th.id);
                return (cmd.ExecuteNonQuery());
            }
        }

    }
}