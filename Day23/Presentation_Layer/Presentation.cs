using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic;

namespace Presentation_Layer
{
    class Presentation
    {
        static void Main(string[] args)
        {
            ProductManagementIO product = new ProductManagementIO();
            bool flag = true;
            while (flag)
            {
                switch (product.Menu())
                {
                    case 1:
                        product.AddProduct();
                        break;
                    case 2:
                        product.AddCategory();
                        break;

                    case 3:
                        product.DisplayAll();
                        break;
                    case 4:
                        product.DisplayProduct();
                        break;
                    case 5:
                        product.Update();
                        product.DisplayAll();
                        
                        break;
                    case 6:
                        product.Delete();
                        product.DisplayAll();
                        break;


                    

                    
                    


                    default:
                        flag = false;
                        break;
                }
            }
        }
    
    }
}
