using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class NewsEkle
    {
        [Key]
        public int id { get; set; }
        public string icerik { get; set; }
        public string category { get; set; }
        public string ozet { get; set; }
        public string resimyol { get; set; }
    }
}
