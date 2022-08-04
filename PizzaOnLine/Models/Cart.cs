using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PizzaOnLine.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Pizza product, int quantity)
        {
            CartLine line = lineCollection
              .Where(p => p.Product.PizzaId == product.PizzaId)
              .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Pizza product)
        {
            lineCollection.RemoveAll(l => l.Product.PizzaId == product.PizzaId);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Product.Price * e.Quantity);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }

        public void Loadtodb()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = Pizza; Integrated Security =true;";
            //string sqlExpression = "";
            for (int i = 0; i < lineCollection.Count; i++)
            {



                using (var cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    var sql = @"INSERT INTO pizza1 (Name, Quantity, Price) VALUES (@na, @quan, @price)";
                    var cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue("@na", lineCollection[i].Product.Name);
                    cmd.Parameters.AddWithValue("@quan", lineCollection[i].Quantity);
                    cmd.Parameters.AddWithValue("@price", lineCollection[i].Product.Price * lineCollection[i].Quantity);
                    var dr = cmd.ExecuteReader();
                }
            }
        }
    }
}

