using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Schema
{
    public class Entity
    {
        private int _Id;
        private string _Name;
        private string _Author;
        private string _Publisher;
        private decimal _Price;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Author
        {
            get
            {
                return _Author;
            }
            set
            {
                _Author = value;
            }
        }
        public string Publisher
        {
            get
            {
                return _Publisher;
            }
            set
            {
                _Publisher = value;
            }
        }
        public decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
    }
}
