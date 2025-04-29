using Entities.Entidades_Definicion;

namespace ProyectoEDI.Components.Services
{
    public class MessageService
    {
        private readonly List<Message> _messages = new List<Message>();

        public List<Message> GetMessages()
        {
            return _messages;
        }

        public void AddMessage(Message message)
        {
            if (message != null)
            {
                _messages.Add(message);
            }
        }
    }
}
