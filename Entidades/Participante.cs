using System.ComponentModel.DataAnnotations;
using WebApiLoteria.Validaciones;

namespace WebApiLoteria.Entidades
{
    public class Participante : IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es necesario")]
        [StringLength(maximumLength: 15, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es necesario")]
        [StringLength(maximumLength: 15, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [PrimeraLetraMayuscula]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "El campo {0} es necesario")]
        [StringLength(maximumLength: 15, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [PrimeraLetraMayuscula]
        public string ApellidoMaterno { get; set; }
     
        [StringLength(maximumLength: 10, ErrorMessage = "El campo debe tener como maximo 10 caracteres")]
        public string Telefono { get; set; }

        public DateTime? FechaInscripcion { get; set; }





        public List<RifaParticipante> RifasParticipantes { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Nombre))
            {
                var primeraLetra = Nombre[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("Debe ser Mayúscula la primera letra",
                            new string[] { nameof(Nombre) });
                }
            }

            if (!string.IsNullOrEmpty(ApellidoPaterno))
            {
                var primeraLetra = ApellidoPaterno[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("Debe ser Mayúscula la primera letra",
                            new string[] { nameof(ApellidoPaterno) });
                }
            }

            if (!string.IsNullOrEmpty(ApellidoMaterno))
            {
                var primeraLetra = ApellidoMaterno[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("Debe ser Mayúscula la primera letra",
                            new string[] { nameof(ApellidoMaterno) });
                }
            }
        }
    }
}
