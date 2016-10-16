using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Person()
        {
            Person objPerson = new Person();
            objPerson.age = Convert.ToInt32(Request.Form["age"]);
            objPerson.name = Request.Form["name"].ToString();
            objPerson.surname = Request.Form["surname"].ToString();
            objPerson.document = Request.Form["document"].ToString();

            return View(objPerson);
        }
        public ActionResult Index() {

            return View();
        }
        public ActionResult HelloAjax() {

            return Content("Hello Ajax Liliana","text/plain"); 
        }
        public ActionResult SendAjax(Person modelPerson)
        {
            var jsonSerialiser = new JavaScriptSerializer();
           /* var result = new JsonResult();
            result.Data = new {menssage= modelPerson.name };*/

            List<string> list = new List<string>();
            list.Add(modelPerson.name.ToString());
            list.Add(modelPerson.surname.ToString());
            list.Add(modelPerson.document.ToString());
            list.Add(modelPerson.age.ToString());
            list.Add("Data 5");
            String sJson = jsonSerialiser.Serialize(list);

            return Content(sJson, "application/json");
        }
    }
}