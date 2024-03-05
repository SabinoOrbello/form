using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace form.Models
{
    public class Login
    {
        [checkEmail(ListaEmailString = "ebbystronzo@gmail.com,macschifo@gmail.com,sabinochefai@gmail.com", ErrorMessage = ("l'Email e' sbagliata"))]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}