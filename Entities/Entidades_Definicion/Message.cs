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

        public  int MessageId { get; set; }

        [Required]
        public MessageTypeEnum MessageType { get; set; }
        public string MessageVersion { get; set; }
        public string MessageRelease { get; set; }
        public string MessageDirectoryVersion { get; set; }
        public string MessageName { get; set; }
        public string MessageDescription { get; set; }
        public List<MessagePosition> MessagePositions { get; set; }
       
    }
}
