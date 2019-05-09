namespace WebApplication1.App_Data {
    public class Komentar {
        public int KomentarId { get; set; }
        public string Obsah { get; set; }
        public int? DokumentId { get; set; }
        public int? FotoId { get; set; }
        public int UzivatelId { get; set; }
    }
}