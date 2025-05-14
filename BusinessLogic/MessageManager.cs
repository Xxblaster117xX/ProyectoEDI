
using Entities.Entidades_Definicion;
using Entities.Enum;
using Entities.Model.Enum;
using SegmentDefinition = Entities.Entidades_Definicion.SegmentDefinition;
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
        public  Message GetMessageById(int id)
        {
            return _messages.FirstOrDefault(m => m.Id == id);

        }
    }
}


