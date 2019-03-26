using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisasterShop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DisasterShop.Models
{
    public class ABCReportController : Controller
    {
       
        public int OrderID { get; set; }
        public DateTime DateOrdered { get; set; }
        public string[] PhoneNumbers { get; set; }

        public ABCReportModelLineItem[] LineItems { get; set; }
    }
    public class ABCReportModelLineItem
    {
        public string ProductCode { get; set; }
    }
}

namespace DisasterShop.Controllers
{
    public class ABCReportController : Controller
    {
        public IActionResult Index(int id = 1)
        {
            ABCReportModel model = new ABCReportModel();

            //string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ABC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return View(model);
        }
    }
}