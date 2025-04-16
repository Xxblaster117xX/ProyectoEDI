using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Entidades_Definicion;
using Entities.Enum;
using Entities.Model.Enum;

namespace BusinessLogic.Definition
{


    /// <summary>
    /// La clase MessageManager se encarga de manejar los mensajes y sus propiedades.
    /// </summary>
    public class MessageManager : IMessageManager
    {
        public readonly Message message;
        private readonly List<Message> _messages;
     /// <summary>
     /// Constructor de la lista de mensajes
     /// </summary>
        public MessageManager()
        {
            _messages = new List<Message>();
        }
        /// <summary>
        /// Añadir un mensaje
        /// </summary>
        /// <param name="message"></param>

        public void AddMessage(Message message)
        {
            _messages.Add(message);
        }

      /// <summary>
      /// Obtener el mensaje según el tipo
      /// </summary>
      /// <param name="type"></param>
      /// <returns></returns>
        public Message GetMessageByType(MessageTypeEnum message)
        {
            return _messages.FirstOrDefault(m => m.MessageType == message);
        }
        /// <summary>
        /// Obtener la lista de mensajes
        /// </summary>
        /// <returns></returns>
        public List<Message> GetAllMessages()
        {
            return _messages;
        }
        /// <summary>
        /// Valorar si el mensaje tiene segmento mandatory(obligatorio)
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool HasMandatorySegments(Message message, RequirementIndicatorEnum type)
        {
            return message.MessagePositions.Any(pos => pos.RequirementIndicator == type);
        }
        /// <summary>
        /// Valorar si el mensaje tiene segmento conditional(condicional)
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool HasConditionalSegments(Message message, RequirementIndicatorEnum type)
        {
            return message.MessagePositions.Any(pos => pos.RequirementIndicator == type);
        }
        /// <summary>
        /// Obtener los segmentos según el mensaje valorando la posición. Dependiendo de la posición obtiene el segmento en específico 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public List<Segment> GetSegments(Message message)
        {
            return message.MessagePositions
                          .Where(p => p.Segment != null)
                          .Select(p => p.Segment!)
                          .ToList();
        }

       
    }
}

