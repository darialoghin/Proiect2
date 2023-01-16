using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Linq;

namespace Proiect2.Models
{
    public class Manichiura
    {
        public int ID { get; set; }
        [Display(Name = "Despre Manichiura")]
        public string Culoare { get; set; }
        public string Forma { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public int Pret { get; set; }
        public string Desen { get; set; }
        public ICollection<Client> Clienti { get; set; }

    }
}

