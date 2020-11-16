using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

using MMTWebAPI.DataServices;

namespace MMTWebApi.Controllers
{
    public class HomeController : ApiController
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        [System.Web.Http.Route("api/featuredproducts")]

        public List<string> GetFeaturedProducts()
        {


            List<string> FeaturedProducts = SQLRetrieveFeaturedProducts();


                return FeaturedProducts;
        }





        public List<string> SQLRetrieveFeaturedProducts()
        {

            using (var dt = new GetFeaturedItemsDataService(connectionString))
                return dt.GetFeaturedProducts();

        }



        [System.Web.Http.Route("api/categories")]

        

        public List<string> GetCategoriesList()
        {


            List<string> Categories = SQLRetrieveCategoriesList();


            return Categories;
        }




        public List<string> SQLRetrieveCategoriesList()
        {

            using (var dt = new GetCategoriesDataService(connectionString))
                return dt.GetCategoriesList();

        }



        [System.Web.Http.Route("api/itemsincategory")]
        [System.Web.Http.HttpPost]

        public List<string> GetItemsInCategory([FromBody] string Category)
        {


            List<string> Items = SQLRetrieveItemsInCategory(Category);


            return Items;
        }



        public List<string> SQLRetrieveItemsInCategory(string Category)
        {

            using (var dt = new GetItemsInCategoryDataService(connectionString))
                return dt.GetItemsList(Category);

        }


    }
}
