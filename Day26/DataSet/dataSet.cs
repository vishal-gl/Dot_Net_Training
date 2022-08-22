using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSet;
using System.Data.SqlClient;
using System.Data;
namespace DataSet
{
    public class dataSet
    {
        DataSetStudent.StudentDataTable userDt = new DataSetStudent.StudentDataTable();
        DataSetStudentTableAdapters.StudentTableAdapter userDA = new DataSetStudentTableAdapters.StudentTableAdapter();
        public void InsertData(string Id,string Name,int age,int standard,string address,string cid)
        {
            int i = userDA.(Id, Name, age, standard, address, cid);
        }
        public object selectData()
        {
            return userDt = userDA.Select();
        }
    }
}
