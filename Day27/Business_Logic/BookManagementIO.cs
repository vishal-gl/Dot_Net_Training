using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using Book_Schema;
using System.Data;

namespace Business_Logic
{
    public class BookManagementIO
    {

        public int Insert(Book_Schema.Entity objSchema)
        {
            try
            {
                Data_Access_Layer.Services objDAL = new Data_Access_Layer.Services();
                return objDAL.InsertData(objSchema);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(Book_Schema.Entity objSchema, int Id)
        {
            try
            {
                Data_Access_Layer.Services objDAL = new Data_Access_Layer.Services();
                return objDAL.UpdateData(objSchema, Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(int Id)
        {
            try
            {
                Data_Access_Layer.Services objDAL = new Data_Access_Layer.Services();
                return objDAL.DeleteData(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BindGrid()
        {
            try
            {
                Data_Access_Layer.Services objDAL = new Data_Access_Layer.Services();
                return objDAL.BindGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetById(int Id)
        {
            try
            {
                Data_Access_Layer.Services objDAL = new Data_Access_Layer.Services();

                return objDAL.GetById(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
