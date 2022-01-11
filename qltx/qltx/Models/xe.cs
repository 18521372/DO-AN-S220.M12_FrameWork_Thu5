using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
namespace qltx.Models
{
    public class xe
    {
        private string _id;
        private string _csh_id;
        private string _tenxe;
        private string _thuonghieu;
        private string _vitri;
        private string _bienso;
        private DateTime _ngaythue;
        private string _trangthai_id;
        private string _loainhienlieu;     
        private int _giathue;
        private IFormFile _ImageFile;
        private string _tenanh;
        public IFormFile ImageFile
        {
            get { return _ImageFile; }
            set { _ImageFile = value; }
        }
            
public string csh_id
        {
            get { return _csh_id; }
            set { _csh_id = value; }
        }
        public string tenanh
        {
            get { return _tenanh; }
            set { _tenanh = value; }
        }
        public int giathue
        {
            get { return _giathue; }
            set { _giathue = value; }
        }
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string tenxe
        {
            get { return _tenxe; }
            set { _tenxe = value; }
        }
        public string thuonghieu
        {
            get { return _thuonghieu; }
            set { _thuonghieu = value; }
        }
        public string vitri
        {
            get { return _vitri; }
            set { _vitri = value; }
        }
        public string bienso
        {
            get { return _bienso; }
            set { _bienso = value; }
        }
        public DateTime ngaythue
        {
            get { return _ngaythue; }
            set { _ngaythue = value; }
        }
        public string trangthai_id
        {
            get { return _trangthai_id; }
            set { _trangthai_id = value; }
        }
        public string loainhienlieu
        {
            get { return _loainhienlieu; }
            set { _loainhienlieu = value; }
        }
        
    }
}
