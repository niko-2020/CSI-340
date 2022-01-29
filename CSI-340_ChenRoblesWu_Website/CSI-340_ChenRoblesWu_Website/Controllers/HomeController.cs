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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<BookModel> list = new List<BookModel>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = Properties.Resources.ConnectionString;
        }

        public IActionResult Index()
        {
            FetchData();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void FetchData()
        {
            if (list.Count > 0)
            {
                list.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT TOP (1000) [book_id],[title],[isbn13],[language_id],[num_pages],[publication_date],[publisher_id] FROM [gravity_books].[dbo].[book]";
                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new BookModel()
                    {
                        BookId = dr["book_id"].ToString(),
                        Title = dr["title"].ToString(),
                        isbn13 = dr["isbn13"].ToString(),
                        LanguageId = dr["language_id"].ToString(),
                        NumPages = dr["num_pages"].ToString(),
                        PublicationDate = dr["publication_date"].ToString(),
                        PublisherId = dr["publisher_id"].ToString(),

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
