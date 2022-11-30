using System.ComponentModel.DataAnnotations;

namespace WebApiLoteria.Entidades
{
    public class Rifa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(maximumLength: 60, ErrorMessage = "Este campo no puede tener mas de {1} caracteres")]
        public string NombreRifa { get; set; }


        public List<RifaParticipante> RifasParticipantes { get; set; }
        public List<Premio> Premio { get; set; }
    }
}
