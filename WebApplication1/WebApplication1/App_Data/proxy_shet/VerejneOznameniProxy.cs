using System.Collections.Generic;

namespace WebApplication1.App_Data.proxy_shet {
    public abstract class VerejneOznameniProxy {
        private static VerejneOznameniProxy chmpff {
            get{ return new db_shets.VerejneOznameniTable();}
        }
        protected abstract void insert(VerejneOznameni vo);
        protected abstract void update(VerejneOznameni vo);
        protected abstract void delete(VerejneOznameni vo);
        protected abstract List<VerejneOznameni> select(VerejneOznameni vo);
        protected abstract List<VerejneOznameni> select_obec(VerejneOznameni vo, string nazevObce);
        
        public static void Insert(VerejneOznameni vo) {
            chmpff.insert(vo);
        }
        public static void Update(VerejneOznameni vo) {
            chmpff.update(vo);
        }
        public static void Delete(VerejneOznameni vo) {
            chmpff.delete(vo);
        }
        public static List<VerejneOznameni> Select(VerejneOznameni vo) {
            return chmpff.select(vo);
        }public static List<VerejneOznameni> Select_obec(VerejneOznameni vo, string nazevObec) {
            return chmpff.select_obec(vo, nazevObec);
        }
    }
}