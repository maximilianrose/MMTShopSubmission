using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace MMTShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            while (1 == 1) {


                Console.WriteLine("Please Type a command");

                string Command = Console.ReadLine();



                if (Command == "featured products" || Command == "featured")
                {

                    GetFeaturedProducts();

                }


                else if (Command == "categories" || Command == "category")
                {
                    GetCategories();

                }


                else if (Command == "quit")
                {


                    Environment.Exit(0);


                }


                else
                {
                    Console.WriteLine("Invalid Command");

                }




            }

        }

        static void GetFeaturedProducts()
        {

            List<string> FeaturedProducts = new List<string>();

            var json = new WebClient().DownloadString("https://localhost:44398/api/featuredproducts");

            var jsonlist = JsonConvert.DeserializeObject<List<string>>(json);



            FeaturedProducts = jsonlist;

            foreach (var i in FeaturedProducts)
            {

                Console.WriteLine(i);
                Console.WriteLine("");
            }




        }


        static void GetCategories()

        {

            List<string> Categories = new List<string>();

            var json = new WebClient().DownloadString("https://localhost:44398/api/categories");

            var jsonlist = JsonConvert.DeserializeObject<List<string>>(json);



            Categories = jsonlist;

            foreach (var i in Categories)
            {

                Console.WriteLine(i);
                Console.WriteLine("");
            }

            Console.WriteLine("Please Select a Category");

            string Command = Console.ReadLine();

            GetItemsInCategory(Command);


        }


        static void GetItemsInCategory(string Category)
        {

            //Post category name to API and retrieve data sent back 

            List<string> Items = new List<string>();
            
            

            

            foreach (var i in Items)
            {

                Console.WriteLine(i);
                Console.WriteLine("");
            }



            Console.WriteLine("Test3");


        }
    }
}
