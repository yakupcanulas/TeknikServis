﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknik.Entitiy.IdentitiyModels;

namespace Teknik.Entitiy.Entities
{
    public class Ariza
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }
        public string Adres { get; set; }

        [Column(TypeName = "smalldatetime")]

        public DateTime EklemeTarihi { get; set; } = DateTime.Now;
        public DateTime? OnaylamaTarihi { get; set; }
        public bool OnaylandiMi { get; set; }

        [ForeignKey("KullaniciID")]

        public string KullaniciAdi { get; set; }
        public int MarkaID { get; set; }
        public int ModelID { get; set; }
        public string TeknikerID { get; set; }
        public bool ArizaYapildiMi { get; set; }
        public virtual ApplicationUser Gondereni { get; set; }

        [ForeignKey("ModelID")]

        public virtual PcModel Modeli { get; set; }

        [ForeignKey("MarkaID")]

        public virtual PcMarka Markasi { get; set; }
        public List<Fotograf> Fotograflari { get; set; }
        public virtual Anket Anketi { get; set; }
        public virtual List<ArizaBilgilendirme> Bilgilendirmeleri { get; set; } = new List<ArizaBilgilendirme>();


    }
}
