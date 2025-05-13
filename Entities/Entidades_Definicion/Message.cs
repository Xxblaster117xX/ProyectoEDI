using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enum;
using Entities.Model.Enum;

namespace Entities.Entidades_Definicion
{
    public class Message
    {

        public  int Id { get; set; }

        [Required]
        public MessageTypeEnum MessageType { get; set; }
        public string Version { get; set; }
        public string Release { get; set; }
        public string DirectoryVersion { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MessagePosition> MessagePositions { get; set; }
       
    }
}
