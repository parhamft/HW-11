using HW_11.Contracts;
using HW_11.Entities;
using HW_11.Enums;
using HW_11.Reposetories;
using HW_11.services;

IProductReposetory reposetory = new ProductReposetory();
IProductServices services = new ProductServices();


bool stop = false;

while (stop==false)
{
    Console.Clear();
    Console.WriteLine("1)Add a product");
    Console.WriteLine("2)Show products");
    Console.WriteLine("3)Update product");
    Console.WriteLine("4)Delete a product");
    int options =Convert.ToInt32(Console.ReadLine());
    switch(options)
    {
        case 1:
            Console.Clear();
            Console.Write("enter the name of the product : ");
            string Name=Console.ReadLine();
            Console.Write("enter the category of the product(1.Electronics=1,2.Accessories,3.Peripherals,4.Clothing) : ");
            int cat = Convert.ToInt32(Console.ReadLine());
            if (cat<=1 && cat>=4) { Console.WriteLine("that category does not exist");continue; }
            Console.Write("enter the Price of the product : ");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(services.Add(Name,(CategorieEnum)cat,Price));
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine(services.showAll());
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            bool x =false;
            Console.WriteLine(services.showAll());
            Console.WriteLine("please enter the id of the product : ");
            int id  = Convert.ToInt32(Console.ReadLine());
            while  (x==false)
            {
                Console.Clear();
                Console.WriteLine("1)change name");
                Console.WriteLine("2)change category");
                Console.WriteLine("3)change price");
                Console.WriteLine("4)Exit");

                int op=Convert.ToInt32(Console.ReadLine());
                if (op==4) { break; }
                Console.WriteLine("what do you want to change it to : ");
                string New =Console.ReadLine();
                Console.WriteLine(services.Update(id, op, New));
                Console.ReadKey ();
            }
            Console.ReadKey();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine(services.showAll());
            Console.WriteLine("please enter the id of the product : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            services.delete(ID);
            Console.ReadKey();
            break;
    }
}

