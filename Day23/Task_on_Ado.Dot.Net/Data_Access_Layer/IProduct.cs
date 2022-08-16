using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    interface IProduct
    {
         void AddProduct(string PId, string PName, float Pprice, string cid);
        void ReadCategory();

        void DisplayAll();
        bool CheckId(string Id);
        bool CCheckId(string Id);

        void DisplayProduct(string pid);

        void DisplayCategory(string cid);

        void AddCategory(string CId, string CName);
        void Update(byte n, string id, string m);

        bool Delete(string id);

    }
}
