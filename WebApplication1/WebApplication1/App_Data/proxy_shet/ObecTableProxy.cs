using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using WebApplication1.App_Data.proxy_shet;

namespace WebApplication1.App_Data.proxy_shet {
    public abstract class ObecTableProxy {
        private static ObecTableProxy chmpff {
            get { return new db_shets.ObecTable(); }
        }

        protected abstract void insert(Obec obec);
        protected abstract void update(Obec obec);
        protected abstract void delete(Obec obec);
        protected abstract Obec select(Obec obec);
        protected abstract List<Obec> select();

        public static void Insert(Obec obec) {
            chmpff.insert(obec);
        }

        public static void Update(Obec obec) {
            chmpff.update(obec);
        }

        public static void Delete(Obec obec) {
            chmpff.delete(obec);
        }

        public Obec Select(Obec obec) {
            return chmpff.select(obec);
        }

        public static List<Obec> Select() {
            return chmpff.select();
        }
    }
}
