using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;


namespace Entities.Entidades_Representacion
{
    public class Interchange
    {
        public string CreationDate { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public List<Document> Documents { get; set; }
    }
}
