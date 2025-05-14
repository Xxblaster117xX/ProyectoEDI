using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;
using Entities.Model.Enum;

namespace AppLayer
{
    public class MessageAppService
    {
        public readonly List<Message> _messages;
        /// <summary>
        /// Constructor de la lista de mensajes
        /// </summary>
        public MessageAppService()
        {
            _messages = new List<Message>();
        }

        /// <summary>
        /// Método para obtener un mensaje según su Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Message GetMessageById(int id)
        {
            var message = _messages.FirstOrDefault(m => m.Id == id);
            return message;
        }
        /// <summary>
        /// Método para agregar un mensaje a la lista de mensajes.
        /// </summary>
        /// <param name="message"></param>
        public string AddMessage(Message message)
        {
            string errorMessage;
            if (CheckMessage(message, out errorMessage))
            {

                // Agregar el DataElement a la lista
                _messages.Add(message);
                return "Elemento de dato agregado exitosamente.";
            }
            else
            {
                return errorMessage;
            }
        }

        /// <summary>
        ///  Método para obtener un mensaje segñún el tipo de mensaje.
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
        /// Método para actualizar un mensaje 
        /// </summary>
        /// <param name="updatedMessage"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public void UpdateMessage(Message updatedMessage)
        {
            if (updatedMessage == null)
            {
                throw new ArgumentNullException(nameof(updatedMessage), "El mensaje no puede ser nulo.");
            }

            // Buscar el mensaje existente por su ID
            var existingMessage = GetAllMessages().FirstOrDefault(m => m.Id == updatedMessage.Id);

            if (existingMessage == null)
            {
                throw new InvalidOperationException($"No se encontró un mensaje con el ID {updatedMessage.Id}.");
            }

            // Actualizar los campos del mensaje existente
            existingMessage.MessageType = updatedMessage.MessageType;
            existingMessage.Name = updatedMessage.Name;
            existingMessage.Version = updatedMessage.Version;
            existingMessage.Release = updatedMessage.Release;
            existingMessage.DirectoryVersion = updatedMessage.DirectoryVersion;
            existingMessage.Description = updatedMessage.Description;

            Console.WriteLine($"Mensaje con ID {updatedMessage.Id} actualizado correctamente.");
        }




        /// <summary>
        /// Método para verificar si el mensaje es válido y lanza una excepción si no lo es.
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="ArgumentException"></exception>
        public bool CheckMessage(Message message, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrEmpty(message.MessageType.ToString()))
            {
                errorMessage = "El tipo de mensaje no puede ser nulo o vacío.";
                return false;
            }
            else if (message.MessageType == null)
            {
                errorMessage = "El tipo de mensaje es obligatorio.";
            }
            else if (string.IsNullOrWhiteSpace(message.Version))
            {
                errorMessage = "La versión del mensaje no puede ser nula o vacía.";
            }
            else if (message.MessagePositions == null || message.MessagePositions.Count == 0)
            {
                errorMessage = "El mensaje debe contener al menos un segmento.";
            }
            else if (message.MessagePositions.Any(p => p.Segment == null))
            {
                errorMessage = "Todos los segmentos deben estar definidos.";
            }

            return true;
        }
    }



}

