using System.ComponentModel.DataAnnotations;

namespace HelpmeHunter.Presentacion.Landing.ViewModels.Cuenta
{
    public class IndexVM
    {
        [Required(ErrorMessage = "Ingresa tu correo")]
        [EmailAddress(ErrorMessage = "No es un correo válido")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Ingresa tu clave")]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        public bool EsEmpresa { get; set; }
    }
}