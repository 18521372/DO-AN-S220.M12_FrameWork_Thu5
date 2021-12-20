using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qltx.Models
{
    public class thuonghieu
    {
        private string _id;
        private string _tenth;
        private string _quocgia;
        
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string tenth
        {
            get { return _tenth; }
            set { _tenth = value; }
        }
        public string quocgia
        {
            get { return _quocgia; }
            set { _quocgia = value; }
        }
       
    }
}
