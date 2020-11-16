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
    public class GetCategoriesDataService : SqlRepository
    {

        public GetCategoriesDataService(string connectionString) : base(connectionString) { }


        public List<string> GetCategoriesList()
        {
            List<string> CategoryList = new List<string>();

            try
            {
                using (var sql = new SqlCommand("dbo.GetCategoriesList", _conn))
                {

                    sql.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.CommandTimeout = 0;


                    using (var reader = sql.ExecuteReader())
                        while (reader.Read())
                        {




                            string Category = reader["CategoryName"] == DBNull.Value ? "N/A" : reader.GetString(reader.GetOrdinal("CategoryName"));





                            if (string.IsNullOrWhiteSpace(Category) == false)
                            {

                                CategoryList.Add(Category);

                            }

                        }



                }
            }

            catch (Exception ee)
            {
                return null;


            }





            return CategoryList;




        }



    }
}
