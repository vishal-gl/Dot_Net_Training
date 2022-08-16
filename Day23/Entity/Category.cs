using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Category
    {
        string _Cid;
        string _Cname;

        public Category()
        {
        }
        public string GCid()
        {
            return this._Cid;
        }
        public string GCname()
        {
            return this._Cname;
        }
    }
}
