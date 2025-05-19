using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Model.Enum;

namespace Entities.Entidades_Definicion
{
    public class Message
    {

        public int Id { get; set; }
        [Required]
        public TipoDocumento MessageType { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Version { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Release { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Directory { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? DirectoryVersion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Description { get; set; }
        public List<MessagePosition> MessagePositions { get; set; }
    }
}
