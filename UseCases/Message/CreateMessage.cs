using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;

namespace AppLayer.CreateMessage
{
    /// <summary>
    /// En esta clase se crea un mensaje de prueba
    /// </summary>
    public class CreateMessage
    {

        public Message DoMessage(Message message)
        {
            message.MessageType = Entities.Model.Enum.MessageTypeEnum.GENRAL;
            message.MessageVersion = "D.96A";
            message.MessageRelease = "D.96A";
            message.MessageDirectoryVersion = "D.96A";
            message.MessageName = "GENRAL";
            message.MessageDescription = "Mensaje de prueba";
            message.MessagePositions = new List<MessagePosition>();
            
            return message; 
        }

        public static void Main(string[] args)
        {
            var message = new Message();
            var createMessage = new CreateMessage();
            message = createMessage.DoMessage(message);

            Console.WriteLine(" Mensaje creado: tipo de mensaje "+ message.MessageType );
        }
    }
}

