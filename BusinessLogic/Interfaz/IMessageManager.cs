using Entities.Entidades_Definicion;
using Entities.Entidades_Representacion.Abstract;
using Entities.Enum;
using Entities.Model.Enum;

namespace BusinessLogic.Definition
{
    /// <summary>
    /// La interfaz IMessageManager define los métodos para manejar mensajes.
    /// </summary>
    public interface IMessageManager
    {
        void AddMessage(Message message); 
        Message GetMessageByType(MessageTypeEnum message);
        List<Message> GetAllMessages();
        bool GetRequirementIndicator(Message message, RequirementIndicatorEnum type);
        List<Segment> GetSegments(Message message);
        void CheckMessage(Message message);
       

    }
}
