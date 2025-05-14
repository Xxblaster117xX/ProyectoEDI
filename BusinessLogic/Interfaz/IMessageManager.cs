

using Entities.Entidades_Definicion;
using Entities.Enum;
using Entities.Model.Enum;
using SegmentDefinition = Entities.Entidades_Definicion.SegmentDefinition;
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
        List<SegmentDefinition> GetSegments(Message message);
        Message GetMessageById(int id);


    }
}
