using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpmeHunter.Presentacion.Landing.ViewModels.Cuenta
{
    public class EmpresaVM
    {
        [Required(ErrorMessage = "Ingresa la razon social de tu empresa")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "Ingresa el RUC de tu empresa")]
        public string RUC { get; set; }

        [Required(ErrorMessage = "Selecciona el sector al que pertenece tu empresa")]
        public int IdSector { get; set; }

        public string WebSite { get; set; }

        [Required(ErrorMessage = "Ingresa el télefono de tu empresa")]
        public string Telefono { get; set; }

        public string Anexo { get; set; }

        [Required(ErrorMessage = "Ingresa tu celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Selecciona tu país")]
        public int? IdPais { get; set; }

        [Required(ErrorMessage = "Selecciona el país de tu empresa")]
        public int? IdPaisEmpresa { get; set; }

        [Required(ErrorMessage = "Ingresa tus nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Ingresa tus apellidos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Ingresa tu correo corporativo")]
        [EmailAddress(ErrorMessage = "No es un correo válido")]
        [DataType(DataType.EmailAddress)]
        public string CorreoCorporativo { get; set; }

        [Required(ErrorMessage = "Selecciona tu puesto actual")]
        public string PuestoActual { get; set; }

        public SelectList Sectores { get; set; }

        public SelectList Paises { get; set; }
    }
}