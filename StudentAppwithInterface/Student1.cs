﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppwithInterface
{
    
    public class Student
    {

        string _name;
        int _id;
        
        string _address;
        int _marks;

        public Student()
        {

        }
        ~Student()
        {

        }
        public Student(int id, string name, int marks, string address)
        {
            this._id = id;
            this._name = name;
            this._marks = marks;
            this._address = address;
        }
        public int GetID()
        {




            return _id;

        }


        public string GetName()
        {

            return _name;
        }
        public int GetMarks()
        {
            return _marks;
        }
        public string GetAddress()
        {
            return _address;

        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public void SetId(int id)
        {
            this._id = id;

        }




        public void SetMarks(int marks)
        {
            this._marks = marks;

        }

        public void SetAddress(string address)
        {
            this._address = address;
        }

    }
}
