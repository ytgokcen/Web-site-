using System.ComponentModel.DataAnnotations;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string isim { get; set; }
        public string menugorsel { get; set; }
        public string marka { get; set; }
        public string bilgi { get; set; }
    }
}