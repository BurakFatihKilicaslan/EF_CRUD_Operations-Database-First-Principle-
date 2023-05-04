using System;
using System.Collections.Generic;

namespace EF_CRUD_Operations.Models
{
    public partial class VwKritikSeviyeUrunBi1gileri
    {
        public string ÜrünAdı { get; set; } = null!;
        public string Kategori { get; set; } = null!;
        public string TedarikçiFirma { get; set; } = null!;
        public short? MinimumSiparişAdedi { get; set; }
        public decimal? BirimFiyat { get; set; }
    }
}
