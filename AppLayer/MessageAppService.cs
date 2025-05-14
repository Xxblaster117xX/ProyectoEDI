using AppLayer.Interfaces;
using Entities.Entidades_Definicion;
using Entities.Enum;
using Entities.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer
{
    public class MessageAppService : IMessageAppService
    {
        private readonly List<Message> _messages;
        /// <summary>
        /// Constructor de la lista de mensajes
        /// </summary>
        public MessageAppService()
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
            return _messages.FirstOrDefault(m => m.Type == message);
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
        public bool GetRequirementIndicator(Message message, RequirementIndicatorEnum type)
        {
            return message.MessagePositions.Any(pos => pos.RequirementIndicator == type);
        }
        /// <summary>
        /// Valorar si el mensaje tiene segmento conditional(condicional)
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <returns></returns>

        /// <summary>
        /// Obtener los segmentos según el mensaje valorando la posición. Dependiendo de la posición obtiene el segmento en específico 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public List<SegmentDefinition> GetSegments(Message message)
        {
            return message.MessagePositions
                          .Where(p => p.Segment != null)
                          .Select(p => p.Segment)
                          .ToList();
        }

        /*
         metodo para obtener un mensaje por id
         */
        public Message GetMessageById(int id)
        {
            return _messages.FirstOrDefault(m => m.Id == id);

        }
    }
}
