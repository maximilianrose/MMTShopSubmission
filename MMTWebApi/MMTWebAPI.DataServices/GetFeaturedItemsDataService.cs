using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMTWebAPI.DataObjects;
using System.Data.SqlClient;
using MMTWebAPI.DataServices;

namespace MMTWebAPI.DataServices
{
    public class GetFeaturedItemsDataService : SqlRepository
    {

        public GetFeaturedItemsDataService(string connectionString) : base(connectionString) { }


        public List<string> GetFeaturedProducts()
        {
            List<string> ProductList = new List<string>();

            try
            {
                using (var sql = new SqlCommand("dbo.GetFeaturedProducts", _conn))
                {

                    sql.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.CommandTimeout = 0;


                    using (var reader = sql.ExecuteReader())
                        while (reader.Read())
                        {
                            

                            

                            string product = reader["ProductName"] == DBNull.Value ? "N/A" : reader.GetString(reader.GetOrdinal("ProductName"));

                           



                            if (string.IsNullOrWhiteSpace(product)== false)
                            {

                                ProductList.Add(product);

                            }

                        }



                }
            }

            catch (Exception ee)
            {
                return null;


            }





            return ProductList;




        }



    }
}
