using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using AutoInsuranceQuote.Models;

namespace AutoInsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, 
                                    string carModel, string DUI, int speedingTicket, string fullCoverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake)
                || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                Customer newCustomer = new Customer();
                newCustomer.FirstName = firstName;
                newCustomer.LastName = lastName;
                newCustomer.EmailAddress = emailAddress;
                newCustomer.DateOfBirth = dateOfBirth;
                newCustomer.CarYear = carYear;
                newCustomer.CarMake = carMake;
                newCustomer.CarModel = carModel;
                newCustomer.DUI = DUI;
                newCustomer.SpeedingTicket = speedingTicket;
                newCustomer.FullCoverage = fullCoverage;

                double quote = newCustomer.GetQuote();

                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Insurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                string queryString = @"INSERT INTO Customers (FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, 
                                        CarModel, DUI, SpeedingTicket, FullCoverage, Quote) VALUES (@FirstName, @LastName, @EmailAddress, 
                                        @DateOfBirth, @CarYear, @CarMake, @CarModel, @DUI, @SpeedingTicket, @FullCoverage, @Quote)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.Date);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUI", SqlDbType.VarChar);
                    command.Parameters.Add("@SpeedingTicket", SqlDbType.Int);
                    command.Parameters.Add("@FullCoverage", SqlDbType.VarChar);
                    command.Parameters.Add("@Quote", SqlDbType.Decimal);

                    command.Parameters["@FirstName"].Value = newCustomer.FirstName;
                    command.Parameters["@LastName"].Value = newCustomer.LastName;
                    command.Parameters["@EmailAddress"].Value = newCustomer.EmailAddress;
                    command.Parameters["@DateOfBirth"].Value = newCustomer.DateOfBirth;
                    command.Parameters["@CarYear"].Value = newCustomer.CarYear;
                    command.Parameters["@CarMake"].Value = newCustomer.CarMake;
                    command.Parameters["@CarModel"].Value = newCustomer.CarModel;
                    command.Parameters["@DUI"].Value = newCustomer.DUI;
                    command.Parameters["@SpeedingTicket"].Value = newCustomer.SpeedingTicket;
                    command.Parameters["@FullCoverage"].Value = newCustomer.FullCoverage;
                    command.Parameters["@Quote"].Value = quote;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }
        }
    }
}