using System.ComponentModel.DataAnnotations;

namespace HelpmeHunter.Presentacion.Landing.ViewModels.Cuenta
{
    public class ProfesionalVM
    {
        [Required(ErrorMessage = "Selecciona una razón de empleo")]
        public int IdRazonEmpleo { get; set; }

        public int[] IdSector { get; set; }

        public int[] IdArea { get; set; }

    }
}