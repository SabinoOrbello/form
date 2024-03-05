using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace form
{
    public class checkEmail : ValidationAttribute
    {
        public string ListaEmailString { get; set; }
        public checkEmail() { }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] listaEmail = ListaEmailString.ToString().Split(',');
            if (listaEmail.Contains(value))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Non e' ammesso");
            }
        }
    }
}