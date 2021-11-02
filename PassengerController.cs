using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlightBooking.Models;
using flightBAL;
using flightDAL;
namespace FlightBooking.Controllers
{
    public class PassengerController : Controller
    {
        // GET: Passenger
        public ActionResult BookMyTicket()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BookMyTicket(PassengerModel passenger)
        {
            PassengerDAL dal = new PassengerDAL();

            PassengerBAL b = new PassengerBAL();
            b.PassID = passenger.PassID;
            b.PassName = passenger.PassName;
            b.Age = passenger.Age;
            b.FlightID = passenger.FlightID;
            int tno=dal.BookTicket(b);

            return Content("Your ticket booking reference =" + tno);
        }

        
    }
}