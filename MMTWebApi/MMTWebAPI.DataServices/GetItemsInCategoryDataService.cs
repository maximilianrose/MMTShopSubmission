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
    public class GetItemsInCategoryDataService : SqlRepository
    {

        public GetItemsInCategoryDataService(string connectionString) : base(connectionString) { }


        public List<string> GetItemsList(string Category)
        {
            List<string> ItemsList = new List<string>();

            try
            {
                using (var sql = new SqlCommand("dbo.GetItemsInCategory", _conn))
                {

                    sql.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.CommandTimeout = 0;


                    using (var reader = sql.ExecuteReader())
                        while (reader.Read())
                        {




                            string Product = reader["ProductName"] == DBNull.Value ? "N/A" : reader.GetString(reader.GetOrdinal("ProductName"));





                            if (string.IsNullOrWhiteSpace(Product) == false)
                            {

                                ItemsList.Add(Product);

                            }

                        }



                }
            }

            catch (Exception ee)
            {
                return null;


            }





            return ItemsList;




        }



    }
}
