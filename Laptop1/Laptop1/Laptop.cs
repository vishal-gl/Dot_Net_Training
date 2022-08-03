using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop1
{
    class Laptop
    {
        #region Data Fields
        string _laptopName;
        int _modelNumber;
        float _amount;
        byte _ram;


        #endregion
        #region Constructors

        public Laptop()
        {

        }

        /// <summary>
        /// Paramerised Constructor
        /// </summary>
        /// 
        public Laptop(string laptopName,int modelNumber,float amount,byte ram)
        {
            this._laptopName = laptopName;
            this._modelNumber = modelNumber;
            this._amount = amount;
            this._ram = ram;
        }
        #endregion

        #region properties

        public string GetLaptopName()
        {
            return _laptopName;
        }

        public int GetModelNumber()
        {
            return _modelNumber;
        }

        public float GetAmount()
        {
            return _amount;
        }

        public byte GetRam()
        {
            return _ram;
        }

        #endregion

        ///<summary> 
        ///Method to check the length of the laptop Name
        ///</summary>

        public void SetLaptopName(string laptopName)
        {
            if (laptopName.Length != 0)
            {
                this._laptopName = laptopName;
            }
        }

        public void SetModelNumber(int modelNumber)
        {
            if (modelNumber != 0)
            {
                this._modelNumber = modelNumber;
            }
        }

        public void SetAmount(float amount)
        {
            if (_amount != 0)
            {
                this._amount = amount;
            }
        }

        public void SetRam(byte ram)
        {
            if (ram != 0)
            {
                this._ram = ram;
            }
        }
    }
}
