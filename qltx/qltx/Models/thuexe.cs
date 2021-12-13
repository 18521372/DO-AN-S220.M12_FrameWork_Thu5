using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qltx.Models
{
    public class thuexe
    {
        private string _id;
        private string _nsd_id;
        private string _xe_id;
        private string _email;
        private string _trangthai;
        private int _tongtien;
        private DateTime _batdau;
        private DateTime _ketthuc;
        private string _thanhtoan;
        private string _sodienthoai;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string xe_id
        {
            get { return _xe_id; }
            set { _xe_id = value; }
        }
        public string nsd_id
        {
            get { return _nsd_id; }
            set { _nsd_id = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
        public int tongtien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
        public DateTime batdau
        {
            get { return _batdau; }
            set { _batdau = value; }
        }
        public DateTime ketthuc
        {
            get { return _ketthuc; }
            set { _ketthuc = value; }
        }
        public string thanhtoan
        {
            get { return _thanhtoan; }
            set { _thanhtoan = value; }
        }
        
        public string sodienthoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }
    }
}
