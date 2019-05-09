using System;

namespace WebApplication1.App_Data {
    public class Uzivatel {
        public int UzivatelId { get; set; }
        public string Nick { get; set; }
        public string Heslo { get; set; }
        public string Email { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public int Ban { get; set; }
        public int ObecId { get; set; }
    }
}