using System;

namespace WebApplication1.App_Data {
    public class Fotografie {
        public int FotoId { get; set; }
        public string Nazev { get; set; }
        public DateTime Datum { get; set; }
        public string Popis { get; set; }
        public int AlbumId { get; set; }
        public int Visible { get; set; }
    }
}