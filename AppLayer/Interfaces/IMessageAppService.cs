using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;
using Entities.Enum;
using Entities.Model.Enum;

namespace AppLayer.Interfaces
{
    public interface IMessageAppService
    {

        void AddMessage(Message message);
        Message GetMessageByType(MessageTypeEnum message);
        List<Message> GetAllMessages();
        bool GetRequirementIndicator(Message message, RequirementIndicatorEnum type);
        List<SegmentDefinition> GetSegments(Message message);
        Message GetMessageById(int id);
    }
}
