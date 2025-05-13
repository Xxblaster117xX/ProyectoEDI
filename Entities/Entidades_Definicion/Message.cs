using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Model.Enum;

namespace Entities.Entidades_Definicion
{
    public class Message
    {
        public int MessageId { get; set; }

        public MessageTypeEnum MessageType;
        public string MessageVersion { get; set; }

        public string MessageRelease { get; set; }
        // tipo de directory por ejemplo (UN)
        public string? Directory { get; set; }

        // ejemplo EAN005
        public string MessageDirectoryVersion { get; set; }
        public string MessageName { get; set; }
        public string MessageDescription { get; set; }
        public List<MessagePosition> MessagePositions { get; set; }
    }
}
