using AutoInsuranceQuote.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsuranceQuote.Controllers
{
    public class AdminController : Controller
    {
        //Type in /Admin/Index after the URL to get to the admin page.
        // GET: Admin
        public ActionResult Index()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Insurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, Quote FROM Customers";

            List<Customer> customerList = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var customer = new Customer();
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.EmailAddress = reader["EmailAddress"].ToString();
                    customer.Quote = Convert.ToInt32(reader["Quote"]);

                    customerList.Add(customer);
                }
            }
            return View(customerList);
        }
    }
}