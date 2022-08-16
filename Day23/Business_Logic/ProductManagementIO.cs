using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic
{
    public class ProductManagementIO
    {
        ProductService service = new ProductService();
        public byte Menu()
        {
            Console.WriteLine("Press 1 to Add Product Details");
            Console.WriteLine("Press 2 to Add Category Table Details");
            Console.WriteLine("Press 3 to Display All Details of Product with Category Details");
            Console.WriteLine("Press 4 to Display Details using Product Id");
            Console.WriteLine("Press 5 to Update Record of Product");
            Console.WriteLine("Press 6 to delete a Record in Product Data using Product Id");
            Console.WriteLine("Press 7 to Exit");
            Console.WriteLine("Enter Your choice:");
            try
            {
                byte option = Convert.ToByte(Console.ReadLine());
                if (option > 7)
                {
                    throw new Validation();
                }
                return option;
            }
            catch (Validation V)
            {
                V.Input();
                return Menu();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return Menu();
            }
        }

        public void AddProduct()
        {
            try
            {
                Console.WriteLine("Enter Product Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Product ID : ");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Product Price : ");
                float price = float.Parse(Console.ReadLine());
                
                
                

                Console.WriteLine();
                Console.WriteLine("This is List of Categories which we are Offered : ");

                service.ReadCategory();
                Console.WriteLine();
                Console.WriteLine("Enter Category ID : ");
                string cid = Console.ReadLine();

                
                service.AddProduct(id, name, price,cid);

                Console.WriteLine();
            }
            catch (Validation v)
            {
                v.Input();
                
                Console.WriteLine();

                Menu();
            }



        }

        public void DisplayAll()
        {
            Console.WriteLine();
            service.DisplayAll();
            Console.WriteLine();
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Enter the Product Id :");
            string pid = Console.ReadLine();
            if (service.CheckId(pid))
            {
                service.DisplayProduct(pid);
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("The record is not found with this Product Id");
                Console.WriteLine();
            }
                
            
            
        }
        public void AddCategory()
        {
            try
            {
                Console.WriteLine("Enter Category ID starts with C :");
                string Cid = Console.ReadLine();
                Console.WriteLine("Enter Category Name :");
                string Cname = Console.ReadLine();

               


                Console.WriteLine();


                service.AddCategory(Cid, Cname);

                Console.WriteLine();
            }
            catch (Validation v)
            {
                v.Input();

                Console.WriteLine();

                Menu();
            }



        }

        public void Update()
        {
            Console.WriteLine("Enter the Id of Product whose you want to Update Information : ");
            string Id = Console.ReadLine();
            if (service.CheckId(Id))
            {
                Console.Write("Enter 1 to Update Product Id\nEnter 2 to Product Name\nEnter 3 to Update Price\nEnter 4 to Update Category Id\nEnter Your Choice : ");
                byte n = byte.Parse(Console.ReadLine());
                try
                {
                    if (n > 4)
                    {
                        throw new Validation();
                    }
                }
                catch (Validation e)
                {
                    e.Input();
                }
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter the new Product Id : ");
                        string m = Console.ReadLine();
                        service.Update(n, Id, m);
                        Console.WriteLine("-------------------------");
                        break;
                    case 2:
                        Console.Write("Enter the New Product Name  : ");
                        string m1 = Console.ReadLine();
                        service.Update(n, Id, m1);
                        break;
                    case 3:
                        Console.Write("Enter the New Price  : ");
                        string m2 = Console.ReadLine();
                        service.Update(n, Id, m2);
                        break;
                    case 4:
                        Console.Write("Enter the New Category Id : ");
                        string m5 = Console.ReadLine();
                        service.Update(n, Id, m5);
                        break;

                    



                }

            }
        }

        public void Delete()
        {
            try
            {
                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();
                if (service.Delete(id))
                {
                    Console.WriteLine("Product deleted successfully");
                }
                else
                {
                    Console.WriteLine("Product Id is Not Found!");
                }
            }
            catch (Validation v)
            {
                v.Input();
                Delete();
            }
        }
    }
}
