using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qltx.Models
{
    public class nguoidung
    {
        private string _id;
        private string _ten;
        private string _email;
        private string _diachi;
        private string _gioitinh;
        private DateTime _ngaysinh;
        private string _id_card;
        private string _password;
        private string _sodienthoai;
        private int _quyen;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public DateTime ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string id_card
        {
            get { return _id_card; }
            set { _id_card = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string sodienthoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }
        public int quyen
        {
            get { return _quyen; }
            set { _quyen = value; }
        }
    }
}
