using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            GenricArray c = new GenricArray();
            //c.CreateOneDimensionalArray();
            //c.CreateTwoDimesionalArray();
            //c.JaggedArray();

            GenricList GL = new GenricList();
            //GL.Method();

            GenricQueue q = new GenricQueue();
            //q.Method();

            GenricHashMap GH = new GenricHashMap();
            GH.Method();
            Console.ReadKey();


            
                
        

            /*
             *          
                        FoodBus f1 = new FoodBus("Samosa", 15);
                        Gernric <FoodBus> obj = new Gernric<FoodBus>(f1);
                        Console.WriteLine("ItemName : {0} | Price : {1} ", obj.Show.MenuItemName,obj.Show.ItemPrice);
            */
            /*
                        Country c = new Country("India", "Delhi");
                        GenericClass<Country> GC = new GenericClass<Country>(c);
                        Console.WriteLine("CountryName : {0} | StateName : {1}", GC.GenricVal.CountryName, GC.GenricVal.StateName);
            */












            Console.ReadKey();
        }
    }
}
