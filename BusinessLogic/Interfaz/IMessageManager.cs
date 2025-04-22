
using Entities.Abstract;
using Entities.Entidades_Definicion;
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
        bool HasMandatorySegments(Message message, RequirementIndicatorEnum type);
        bool HasConditionalSegments(Message message, RequirementIndicatorEnum type);
        List<Segment> GetSegments(Message message);
        void CheckMessage(Message message);


    }
}
