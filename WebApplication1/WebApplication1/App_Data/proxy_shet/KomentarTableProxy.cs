using System.Collections.Generic;

namespace WebApplication1.App_Data.proxy_shet {
    public abstract class KomentarTableProxy {
        private static KomentarTableProxy chmpff {
            get{ return new db_shets.KomentarTable();}
        }
        protected abstract void insert(Komentar komentar);
        protected abstract void update(Komentar komentar);
        protected abstract void delete(Komentar komentar);
        protected abstract Komentar select(Komentar komentar);
        protected abstract List<Komentar> select_foto(int fotoId);
        protected abstract List<Komentar> select_dokument(int dokumentId);
        
        public static void Insert(Komentar komentar) {
            chmpff.insert(komentar);
        }
        public static void Update(Komentar komentar) {
            chmpff.update(komentar);
        }
        public static void Delete(Komentar komentar) {
            chmpff.delete(komentar);
        }
        public static Komentar Select(Komentar komentar) {
            return chmpff.select(komentar);
        }
        public static List<Komentar> Select_foto(int fotoId) {
            return chmpff.select_foto(fotoId);
        }
        public static List<Komentar> Select_dokument(int dokumentId) {
            return chmpff.select_foto(dokumentId);
        }

    }
}