using System.Collections.Generic;

namespace WebApplication1.App_Data.proxy_shet {
    public abstract class FotografieTableProxy {
        private static FotografieTableProxy chmpff {
            get { return new db_shets.FotografieTable();}
        }
        protected abstract void insert(Fotografie fotografie);
        protected abstract void update(Fotografie fotografie);
        protected abstract void delete(Fotografie fotografie);
        protected abstract Fotografie select(Fotografie fotografie);
        protected abstract List<Fotografie> select_alb(int albumId);
        
        public static void Insert(Fotografie fotografie) {
            chmpff.insert(fotografie);
        }
        public static void Update(Fotografie fotografie) {
            chmpff.update(fotografie);
        }
        public static void Delete(Fotografie fotografie) {
            chmpff.delete(fotografie);
        }
        public static Fotografie Select(Fotografie fotografie) {
            return chmpff.select(fotografie);
        }
        public static List<Fotografie> Select_rubr(int albumId) {
            return chmpff.select_alb(albumId);
        }

    }
}