using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    [Serializable]
    public class Person
    {
        public int age { get; set; }
        public string  name { get; set; }
        public string surname { get; set; }
        public string document { get; set; }
    }
}