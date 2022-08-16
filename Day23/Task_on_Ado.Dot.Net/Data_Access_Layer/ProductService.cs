using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class ProductService
    {
        Sql_Connection std = new Sql_Connection();

        public void AddProduct(string PId, string PName, float Pprice, string cid)
        {
            if (std.InsertPdata(PId, PName, Pprice,cid))
            {
                Console.WriteLine("Product Details Added Successfully!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Failed To Add Product Details");
                Console.WriteLine();
            }
        }
        public void ReadCategory()
        {
            std.ReadCategory();
        }

        public void DisplayAll()
        {
            if (std.GetNumberOfRecords() != 0)
            {
                Console.WriteLine("All Product Details Are Shown Below:");
                std.ReadData();
            }

            else
            {
                Console.WriteLine("No Data Found, First Add Some Students");
            }
        }

        public bool CheckId(string Id)
        {

            if (std.CheckId(Id))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Input Id is not available in Record");
                return false;

            }


        }
        public bool CCheckId(string Id)
        {

            if (std.CheckCId(Id))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Input Id is not available in Record");
                return false;

            }


        }

        public void DisplayProduct(string pid)
        {
            std.ReadDataProduct(pid);
        }

        public void DisplayCategory(string cid)
        {
            std.ReadDataCategory(cid);
        }

        public void AddCategory(string CId, string CName)
        {
            if (std.InsertCategory(CId, CName))
            {
                Console.WriteLine("Category Details Added Successfully!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Failed To Add Category Details");
                Console.WriteLine();
            }
        }
        public void Update(byte n, string id, string m)
        {
            if (std.Update(n, id, m))
            {
                Console.WriteLine("Product Details Updated Successfully!");
            }
            else
            {
                Console.WriteLine("\nProduct Id  Not Found");
            }

        }

        public bool Delete(string id)
        {
            if (std.GetNumberOfRecords() > 0)
            {
                if (std.DeleteData(id))
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
