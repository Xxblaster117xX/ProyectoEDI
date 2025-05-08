using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class SegmentDefinition
    {
        public int SegmentId { get; set; }

        [Required(ErrorMessage = "El campo Código es obligatorio.")]
        public string SegmentCode { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string SegmentName { get; set; }
        [Required(ErrorMessage = "El campo Descripción es obligatorio.")]
        public string SegmentDescription { get; set; }
        public bool Obligatory { get; set; } = false;
        public List<SegmentPosition>  SegmentPositions { get; set; }
        
    }
}
