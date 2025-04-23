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
        public List<Segment> GetSegments(Message message)
        {
            return message.MessagePositions
                          .Where(p => p.Segment != null)
                          .Select(p => p.Segment)
                          .ToList();
        }

        /// <summary>
        /// Valida el mensaje y lanza una excepción si no cumple con los requisitos.
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="ArgumentException"></exception>
        public void CheckMessage(Message message)
        {
            if (string.IsNullOrEmpty(message.MessageType.ToString()))
            {
                throw new ArgumentException("El tipo de mensaje no puede ser nulo o vacío.");
            }
            else if (message.MessageType == null)
            {
                throw new ArgumentException("El tipo de mensaje es obligatorio.");
            }
            else if (string.IsNullOrWhiteSpace(message.MessageVersion))
            {
                throw new ArgumentException("La versión del mensaje no puede ser nula o vacía.");
            }
            else if (message.MessagePositions == null || message.MessagePositions.Count == 0)
            {
                throw new ArgumentException("El mensaje debe contener al menos un segmento.");
            }
            else if (message.MessagePositions.Any(p => p.Segment == null))
            {
                throw new ArgumentException("Todos los segmentos deben estar definidos.");
            }
            else if (message.MessagePositions.Any(p => p.RequirementIndicator == RequirementIndicatorEnum.M && p.Segment == null))
            {
                throw new ArgumentException("Los segmentos obligatorios no pueden ser nulos.");
            }
            else if (message.MessagePositions.Any(p => p.RequirementIndicator == RequirementIndicatorEnum.C && p.Segment == null))
            {
                throw new ArgumentException("Los segmentos condicionales no pueden ser nulos.");
            }
        }
    }
}

