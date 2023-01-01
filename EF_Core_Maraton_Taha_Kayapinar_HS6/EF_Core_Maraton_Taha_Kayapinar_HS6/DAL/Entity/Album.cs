using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Entity
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string Singer { get; set; }                // Sanatçı-Şarkıcı
        public DateTime BirthDate { get; set; }           // Albüm çıkış tarihi
        public double Price { get; set; }                 // Albüm Fiyatı
        public double DiscountRate { get; set; }           // İndirim oranı
        public bool SalesYorN { get; set; }               // Satış devam ediyormu ?

    }
}
