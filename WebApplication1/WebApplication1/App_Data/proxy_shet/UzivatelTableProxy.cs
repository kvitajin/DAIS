using System.Collections.Generic;

namespace WebApplication1.App_Data.proxy_shet {
    public abstract class UzivatelTableProxy {
        private static UzivatelTableProxy chmpff {
            get{ return  new db_shets.UzivatelTable();}
        }
        protected abstract void insert(Uzivatel uzivatel);
        protected abstract void update(Uzivatel uzivatel);
        protected abstract void delete(Uzivatel uzivatel);
        protected abstract Uzivatel select(Uzivatel uzivatel);
        protected abstract List<Uzivatel> select();
        protected abstract List<Uzivatel> select_obec(int obecId);
        protected abstract void zmena_prav(Uzivatel uzivatel, string prava);
        
        public static void Insert(Uzivatel uzivatel) { 
            chmpff.insert(uzivatel);
        }

        public static void Update(Uzivatel uzivatel) {
            chmpff.update(uzivatel);
        }

        public static void Delete(Uzivatel uzivatel) {
            chmpff.delete(uzivatel);
        }

        public static Uzivatel Select(Uzivatel uzivatel) {
            return chmpff.select(uzivatel);
        }

        public static List<Uzivatel> Select() {
            return chmpff.select();
        } 
        
        public static List<Uzivatel> Select_obec(int obecId) {
            return chmpff.select();
        }

        public static void Zmena_prav(Uzivatel uzivatel, string prava) {
            chmpff.zmena_prav(uzivatel, prava);
        }
        
    }
}