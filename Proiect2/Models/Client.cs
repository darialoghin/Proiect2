namespace Proiect2.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Nume { get; set; }

        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }

        public int? ManichiuraID { get; set; }
        public Manichiura? Manichiura { get; set; }
    }
}
