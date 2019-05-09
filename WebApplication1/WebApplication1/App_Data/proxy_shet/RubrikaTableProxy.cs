using System.Collections.Generic;

namespace WebApplication1.App_Data.proxy_shet {
    public abstract class RubrikaTableProxy {
        private static RubrikaTableProxy chmpff {
            get{ return new db_shets.RubrikaTable();}
        }
        protected abstract void insert(Rubrika rubrika);
        protected abstract void update(Rubrika rubrika);
        protected abstract void delete(Rubrika rubrika);
        protected abstract Rubrika select(Rubrika rubrika);
        protected abstract List<Rubrika> select();

        public static void Insert(Rubrika rubrika) {
            chmpff.insert(rubrika);
        }

        public static void Update(Rubrika rubrika) {
            chmpff.update(rubrika);
        }

        public static void Delete(Rubrika rubrika) {
            chmpff.delete(rubrika);
        }

        public Rubrika Select(Rubrika rubrika) {
            return chmpff.select(rubrika);
        }

        public static List<Rubrika> Select() {
            return chmpff.select();
        }    }
}