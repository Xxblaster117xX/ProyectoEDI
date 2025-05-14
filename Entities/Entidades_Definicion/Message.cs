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
        public int Id { get; set; }

        public MessageTypeEnum Type;
        public string Version { get; set; }

        public string Release { get; set; }
        // tipo de directory por ejemplo (UN)
        public string? Directory { get; set; }

        // ejemplo EAN005
        public string DirectoryVersion { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MessagePosition> MessagePositions { get; set; }
    }
}
