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

        public int MessageId { get; set; }

        [Required]
        public MessageTypeEnum MessageType { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string MessageVersion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string MessageRelease { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string MessageDirectoryVersion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string MessageName { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string MessageDescription { get; set; }
        public List<MessagePosition> MessagePositions { get; set; }
        public static List<Message> MessagesList { get; } = new List<Message>();
    }
}
