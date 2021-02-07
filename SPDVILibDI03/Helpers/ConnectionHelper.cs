using Dapper;
using SPDVILibDI03.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDVILibDI03.Helpers
{
    class ConnectionHelper
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdventureWorks2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static ProductModel getProductModel(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"EXEC uspGetProductModelById {id}";
                ProductModel productModel = conn.Query<ProductModel>(sql).FirstOrDefault();
                return productModel;
            }
        }

        public static List<Product> getProductSizes(int id)
        {
            List<Product> fSizes = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"EXEC uspGetProductSizes {id}";
                var products = conn.Query<Product>(sql);
                
                foreach (Product product in products)
                {
                    bool alreadyExists = false;

                    foreach(Product p in fSizes)
                    {
                        if (p.Size == product.Size)
                            alreadyExists = true;
                    }
                    if (!alreadyExists)
                        fSizes.Add(product);
                }
            }
            return fSizes;
        }

        public static int getRandomId()
        {
            int rId = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "EXEC uspGetAllProductIds";
                var ids = conn.Query<int>(sql).ToList();
                Random rnd = new Random();
                int randomInt = rnd.Next(0, ids.Count);
                rId = ids[randomInt];
            }
            return rId;
        }
    }
}
