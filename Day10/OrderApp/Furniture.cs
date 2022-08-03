using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    
    public class Furniture
    {
        int _orderId, _quantity;
        float _totalAmount;
        string _orderDate, _furnitureType;
        string _paymentMode;

        public Furniture()
        {

        }
        public Furniture(int orderId,string orderDate,string furnitureType,int quantity,float totalAmount,string paymentMode)
        {
            this._orderId = orderId;
            this._orderDate = orderDate;
            this._furnitureType = furnitureType;
            this._quantity = quantity;
            this._totalAmount = totalAmount;
            this._paymentMode = paymentMode;
            
        }

        public int getOrderId()
        {
            return _orderId;
        }
        public string getOrderDate()
        {
            return _orderDate;

        }
        public int getQuantity()
        {
            return _quantity;

        }
        public string getFurnitureType()
        {
            return _furnitureType;

        }
        public string getPaymentMode()
        {
            return _paymentMode;

        }
        public float getTotalAmount()
        {
            return _totalAmount;

        }
        public void SetOrderDate(string orderDate)
        {
            this._orderDate =orderDate;
        }
        public void SetOrderId(int orderId)
        {
            this._orderId = orderId;
        }
        public void SetOrderQuantity(int quantity)
        {
            this._quantity = quantity;
        }
        public void SetFurnitureType(string furnitureType)
        {
            this._furnitureType = furnitureType;
        }
        public void SetTotalAmount(float totalAmount)
        {
            this._totalAmount = totalAmount;
        }
        public void SetPaymentMode(string paymentMode)
        {
            this._paymentMode = paymentMode;
        }





    }

    public class Chair : Furniture
    {
        string _chairType, _purpose, _woodenType, _steelType, _plasticType;
        float _rate;

        public Chair()
        {

        }

        Chair(string chairType,string purpose,string woodenType,string steelType,string plasticType,float rate)
        {
            this._chairType = chairType;
            this._purpose = purpose;
            this._woodenType = woodenType;
            this._steelType = steelType;
            this._plasticType = plasticType;
            this._rate = rate;
        }
        public void SetChairType(string chairType)
        {
            this._chairType = chairType;
        }
        public void SetPurpose(string purpose)
        {
            this._purpose = purpose;
        }
        public void SetWoodenType(string woodenType)
        {
            this._woodenType = woodenType;
        }
        public void SetSteelType(string steelType)
        {
            this._steelType = steelType;
        }
        public void SetPlasticType(string plasticType)
        {
            this._plasticType = plasticType;
        }
        public void SetRate(float rate)
        {
            this._rate = rate;
        }

        public string GetChairType()
        {
            return _chairType;
        }
        public string GetPurpose()
        {
            return _purpose;
        }
        public string GetWoodenType()
        {
            return _woodenType;
        }
        public string GetSteelType()
        {
            return _steelType;
        }
        public string GetPlasticType()
        {
            return _plasticType;
        }
        public float GetRate()
        {
            return _rate ;
        }

        public void getData()
        {
            Console.WriteLine("Enter the Chair Type : ");
            string s = Console.ReadLine();
            SetChairType(s);
            Console.WriteLine("Purpose : ");
            string s2 = Console.ReadLine();
            SetPurpose(s2);
            switch (s)
            {
                case "Wood":
                    Console.WriteLine("Enter the Wooden type from Teak / Rose ");
                    string s3 = Console.ReadLine();
                    SetWoodenType(s3);
                    break;
                case "Steel":
                    Console.WriteLine("Enter the Steel type from GreySteel / GreenSteel / BrownSteel ");
                    string s4 = Console.ReadLine();
                    SetSteelType(s4);
                    break;
                case "Plastic":
                    Console.WriteLine("Enter the Plastic type from Green/ Red / Blue / White ");
                    string s5 = Console.ReadLine();
                    SetPlasticType(s5);
                    break;
                

            }
            Console.WriteLine("Enter the Rate : ");
            float r = float.Parse(Console.ReadLine());
            SetRate(r);
            Console.WriteLine();

            


        }
        public void showData()
        {
            Console.WriteLine();
            //Chair c = new Chair();
            Console.WriteLine("Chair type is : ",GetChairType());
            Console.WriteLine("Purpose is : ", GetPurpose());
            switch (GetChairType())
            {
                case "Wood":
                    Console.WriteLine("Wooden Type is : ", GetWoodenType());
                    break;
                case "Steel":
                    Console.WriteLine("Steel Type is : ", GetSteelType());
                    break;
                case "Plastic":
                    Console.WriteLine("Plastic Type is : ", GetPlasticType());
                    break;

            }
            Console.WriteLine("Rate is : ", GetRate());
            Console.WriteLine();



        }

    }
    public class Coat : Furniture
    {
        string _coatType, _woodenType, _steelType,_capacity;
        float _rate;

        public Coat()
        {

        }
        Coat(string coatType, string woodenType,string steelType,string capacity,float rate)
        {
            this._coatType = coatType;
            this._woodenType = woodenType;
            this._steelType = steelType;
            this._capacity = capacity;
            this._rate = rate;
        }
        public void SetCotType(string coatType)
        {
            this._coatType = coatType;
        }
        
        public void SetWoodenType(string woodenType)
        {
            this._woodenType = woodenType;
        }
        public void SetSteelType(string steelType)
        {
            this._steelType = steelType;
        }
        public void SetCapacity(string capacity)
        {
            this._capacity = capacity;
        }
        public void SetRate(float rate)
        {
            this._rate = rate;
        }
        public string GetCotType()
        {
            return _coatType;
        }
       
        public string GetWoodenType()
        {
            return _woodenType;
        }
        public string GetSteelType()
        {
            return _steelType;
        }
        public string GetCapacity()
        {
            return _capacity;
        }

        public float GetRate()
        {
            return _rate;
        }

        public void getData()
        {
            Console.WriteLine("Enter the Cot Type : ");
            string s = Console.ReadLine();
            SetCotType(s);
            
            switch (s)
            {
                case "Wood":
                    Console.WriteLine("Enter the Wooden type from Teak / Rose ");
                    string s3 = Console.ReadLine();
                    SetWoodenType(s3);
                    break;
                case "Steel":
                    Console.WriteLine("Enter the Steel type from GreySteel / GreenSteel / BrownSteel ");
                    string s4 = Console.ReadLine();
                    SetSteelType(s4);
                    break;
                


            }

            Console.WriteLine("Enter The capacity type from Single / Double : ");
            String s5 = Console.ReadLine();
            SetCapacity(s5);
            Console.WriteLine("Enter the Rate : ");
            float r = float.Parse(Console.ReadLine());
            SetRate(r);
            Console.WriteLine();

        }
        public void showData()
        {
            Console.WriteLine();
            //Chair c = new Chair();
            Console.WriteLine("Cot type is : ", GetCotType());
           
            switch (GetCotType())
            {
                case "Wood":
                    Console.WriteLine("Wooden Type is : ", GetWoodenType());
                    break;
                case "Steel":
                    Console.WriteLine("Steel Type is : ", GetSteelType());
                    break;
                

            }
            Console.WriteLine("capacity is : ", GetCapacity());
            Console.WriteLine("Rate is : ", GetRate());
            Console.WriteLine();


        }


    }



}
