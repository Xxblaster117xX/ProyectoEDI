
using Entities.Entidades_Definicion;
namespace ProyectoEDI.Services
{
    public class MessageService
    {
        private readonly List<Message> _messages;


        

        public void AddMessage(Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            _messages.Add(message);
        }
      


    }
}
