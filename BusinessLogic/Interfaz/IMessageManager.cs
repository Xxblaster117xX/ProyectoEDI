

using Entities.Entidades_Definicion;

using Entities.Model.Enum;
using Segment = Entities.Entidades_Definicion.Segment;
namespace BusinessLogic.Definition
{
    /// <summary>
    /// La interfaz IMessageManager define los métodos para manejar mensajes.
    /// </summary>
    public interface IMessageManager
    {
        /// <summary>
        /// Método para agregar un mensaje a la lista de mensajes.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        string AddMessage(Message message);
        /// <summary>
        /// Método para obtener un mensaje según su Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Message GetMessageById(int id);
        /// <summary>
        /// Método para obtener un mensaje según su tipo.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Message GetMessageByType(MessageTypeEnum message);
        /// <summary>
        /// Método para obtener la lista de mensajes
        /// </summary>
        /// <returns></returns>
        List<Message> GetAllMessages();
        /// <summary>
        /// Método para obtener la lista de segmentos de un mensaje
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        List<Segment> GetSegments(Message message);
        /// <summary>
        /// Método para actualizar un mensaje existente.
        /// </summary>
        /// <param name="updateMessage"></param>
        void UpdateMessage(Message updateMessage);

        /// <summary>
        /// Método para verificar si un mensaje es válido
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        bool CheckMessage(Message message, out string errorMessage);
       

    }
}
