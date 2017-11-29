using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknik.Entitiy.IdentitiyModels;

namespace Teknik.Entitiy.Entities
{
    public class ArizaBilgilendirme
    {
        [Key]
        public int ID { get; set; }
        public string Aciklama { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime AciklamaZamani { get; set; } = DateTime.Now;
        public bool OlumluMu { get; set; }

        [ForeignKey("YoneticiID")]

        public string YoneticiID { get; set; }

        [ForeignKey("ArizaID")]
        public int ArizaID { get; set; }
        public virtual Ariza Arizasi { get; set; }
        public virtual ApplicationUser Yoneticisi { get; set; }

    }
}
