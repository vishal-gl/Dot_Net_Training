using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        string _Pid;
        string _Pname;
        float _Pprice;
        string _Cid;
        
        static int num = 0;

        public Product()
        {
        }
        public string GPid()
        {
            return this._Pid;
        }
        public string GPname()
        {
            return this._Pname;
        }
        public float GPprice()
        {
            return this._Pprice;
        }
        public string GCid()
        {
            return this._Cid;
        }
       
    }
}
