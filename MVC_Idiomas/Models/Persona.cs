using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Security.AccessControl;
using System.Web.Management;

namespace MVC_Idiomas.Models
{
    public class Persona
    {

        [Display (ResourceType = typeof(Persona),Name = "nombre")]
        [Required(ErrorMessageResourceType = typeof(Persona), ErrorMessageResourceName = "nombre_o")]


        public String Nombre { get; set; }

        [Required(ErrorMessageResourceType = typeof(Persona), ErrorMessageResourceName = "saldo_o")]
        [DataType(DataType.Currency, ErrorMessageResourceType = typeof(Persona), ErrorMessageResourceName = "saldo_c")]
        [Display(ResourceType = typeof(Persona), Name = "saldo")]

        public Double Saldo { get; set; }
    }
}