﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik.Entitiy.Entities
{
    public class Fotograf
    {
        [Key]
        public int ID { get; set; }
        public string Yol { get; set; }

        [ForeignKey("ArizaID")]
        public int ArizaID { get; set; }
        public virtual Ariza Arizasi { get; set; }

    }
}
