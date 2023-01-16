using Proiect2.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Proiect2.Models
{
    public class Operatiune
    {

        public int ID { get; set; }
        public int? AngajatID { get; set; }
        public Salariat? Salariat { get; set; }
        public int? BookID { get; set; }
        public Client? Client { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
