using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstLook.Models
{
    public class Mailing
    {
        //a constructor can be used if wanted, but not necessary
        /*public Mailing(string first, string second, string email)
        {
            FirstName = first;
            LastName = second;
            Email = email;
        }*/

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}