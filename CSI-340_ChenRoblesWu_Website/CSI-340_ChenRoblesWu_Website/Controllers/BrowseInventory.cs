using CSI_340_ChenRoblesWu_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Controllers
{
    public class BrowseInventory : Controller
    {
        public IActionResult BrowseBooks()
        {
            FetchBookData();
            //FetchPriceData();
            return View(listB);

        }

        private readonly ILogger<BrowseInventory> _logger;

        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<BookModel> listB = new List<BookModel>();
        List<PriceModel> listP = new List<PriceModel>();

        public BrowseInventory(ILogger<BrowseInventory> logger)
        {
            _logger = logger;
            con.ConnectionString = Properties.Resources.ConnectionString;
        }


        public void FetchBookData()
        {
            if (listB.Count > 0)
            {
                listB.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT TOP (1000) [book_id],[title],[isbn13],[language_id],[num_pages],[publication_date],[publisher_id] FROM [gravity_books].[dbo].[book]";
                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    listB.Add(new BookModel()
                    {
                        Book_id = int.Parse(dr["book_id"].ToString()),
                        Title = dr["title"].ToString(),
                        isbn13 = dr["isbn13"].ToString(),
                        Language_id = int.Parse(dr["language_id"].ToString()),
                        Num_pages = int.Parse(dr["num_pages"].ToString()),
                        Publication_date =  DateTime.Now, //new DateTime(dr["publication_date"].ToString()),
                        Publisher_id = int.Parse(dr["publisher_id"].ToString()),

                    });

                }

                
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void FetchPriceData()
        {
            if (listP.Count > 0)
            {
                listP.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT TOP (1000) [book_id],[price_id],[price] FROM [gravity_books].[dbo].[Price]";
                dr = com.ExecuteReader();

                

                while (dr.Read())
                {
                    listP.Add(new PriceModel()
                    {
                        book_id = int.Parse(dr["book_id"].ToString()),
                        price_id = int.Parse(dr["price_id"].ToString()),
                        price = int.Parse(dr["price"].ToString()),

                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
